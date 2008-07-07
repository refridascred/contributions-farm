-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    owner TEXT NOT NULL,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_stream_events_level ON stream_events (level);

INSERT INTO stream_events (level, owner, active) VALUES (8, 'green', 43);
INSERT INTO stream_events (level, owner, active) VALUES (21, 'local', 82);
INSERT INTO stream_events (level, owner, active) VALUES (38, 'stable', 39);
