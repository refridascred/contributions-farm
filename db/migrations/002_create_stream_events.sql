-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    score REAL NOT NULL DEFAULT 0,
    region TEXT,
    label TEXT,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stream_events_score ON stream_events (score);
