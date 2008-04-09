-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    ratio REAL,
    count INTEGER NOT NULL DEFAULT 0,
    score REAL NOT NULL DEFAULT 0,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stream_events_ratio ON stream_events (ratio);
