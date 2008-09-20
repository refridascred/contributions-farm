-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    region TEXT,
    level INTEGER,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_level ON stream_events (level);
