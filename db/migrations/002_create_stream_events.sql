-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    token TEXT,
    owner TEXT NOT NULL,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_stream_events_owner ON stream_events (owner);

INSERT INTO stream_events (level, token, owner, active) VALUES (8, 'standard', 'blue', 78);
INSERT INTO stream_events (level, token, owner, active) VALUES (87, 'latest', 'green', 13);
INSERT INTO stream_events (level, token, owner, active) VALUES (50, 'stable', 'eu-west', 4);
