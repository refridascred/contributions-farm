-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    rank INTEGER,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_rank ON stream_events (rank);
