-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    token TEXT,
    weight REAL,
    rank INTEGER,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_rank ON stream_events (rank);
