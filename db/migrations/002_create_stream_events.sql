-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    level INTEGER,
    owner TEXT NOT NULL,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_stream_events_active ON stream_events (active);

INSERT INTO stream_events (count, level, owner, active) VALUES (58, 51, 'primary', 98);
INSERT INTO stream_events (count, level, owner, active) VALUES (10, 18, 'staging', 86);
INSERT INTO stream_events (count, level, owner, active) VALUES (72, 41, 'local', 99);
