-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    score REAL NOT NULL DEFAULT 0,
    ratio REAL,
    weight REAL,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_ratio ON stream_events (ratio);
