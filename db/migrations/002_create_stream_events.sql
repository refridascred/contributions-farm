-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    region TEXT,
    count INTEGER NOT NULL DEFAULT 0,
    score REAL NOT NULL DEFAULT 0,
    rank INTEGER,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_rank ON stream_events (rank);
