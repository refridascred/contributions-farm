-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    token TEXT,
    score REAL NOT NULL DEFAULT 0,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_weight ON stream_events (weight);
