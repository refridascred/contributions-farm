-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    weight REAL,
    active INTEGER NOT NULL DEFAULT 1,
    level INTEGER,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_weight ON stream_events (weight);
