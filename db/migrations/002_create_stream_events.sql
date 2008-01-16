-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    weight REAL,
    active INTEGER NOT NULL DEFAULT 1,
    region TEXT,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_active ON stream_events (active);
