-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    label TEXT,
    count INTEGER NOT NULL DEFAULT 0,
    region TEXT,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_region ON stream_events (region);
