-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    region TEXT,
    score REAL NOT NULL DEFAULT 0,
    rank INTEGER,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_created_at ON stream_events (created_at);
