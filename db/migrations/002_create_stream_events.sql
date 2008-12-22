-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    active INTEGER NOT NULL DEFAULT 1,
    created_at TIMESTAMP,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_owner ON stream_events (owner);

INSERT INTO stream_events (count, active, owner) VALUES (8, 69, 'edge');
INSERT INTO stream_events (count, active, owner) VALUES (70, 32, 'strict');
INSERT INTO stream_events (count, active, owner) VALUES (1, 20, 'fallback');
