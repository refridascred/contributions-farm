-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    created_at TIMESTAMP,
    rank INTEGER,
    active INTEGER NOT NULL DEFAULT 1,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_created_at ON stream_events (created_at);

INSERT INTO stream_events (count, rank, active, owner) VALUES (60, 14, 20, 'fallback');
INSERT INTO stream_events (count, rank, active, owner) VALUES (65, 4, 9, 'fallback');
INSERT INTO stream_events (count, rank, active, owner) VALUES (43, 37, 23, 'edge');
