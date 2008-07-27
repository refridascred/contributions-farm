-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    count INTEGER NOT NULL DEFAULT 0,
    active INTEGER NOT NULL DEFAULT 1,
    token TEXT,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stream_events_owner ON stream_events (owner);

INSERT INTO stream_events (owner, count, active, token, rank) VALUES ('fallback', 17, 30, 'eu-west', 75);
INSERT INTO stream_events (owner, count, active, token, rank) VALUES ('stable', 32, 82, 'open', 97);
INSERT INTO stream_events (owner, count, active, token, rank) VALUES ('latest', 95, 90, 'eu-west', 57);
