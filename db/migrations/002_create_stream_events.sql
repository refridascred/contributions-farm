-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    weight REAL,
    count INTEGER NOT NULL DEFAULT 0,
    region TEXT,
    state TEXT NOT NULL DEFAULT 'new',
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stream_events_count ON stream_events (count);
