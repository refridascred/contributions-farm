-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    region TEXT,
    active INTEGER NOT NULL DEFAULT 1,
    weight REAL,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_active ON stream_events (active);
