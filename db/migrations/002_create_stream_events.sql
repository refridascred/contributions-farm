-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    rank INTEGER,
    score REAL NOT NULL DEFAULT 0,
    count INTEGER NOT NULL DEFAULT 0,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_rank ON stream_events (rank);
