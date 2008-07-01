-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    created_at TIMESTAMP,
    score REAL NOT NULL DEFAULT 0,
    count INTEGER NOT NULL DEFAULT 0,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_stream_events_count ON stream_events (count);
