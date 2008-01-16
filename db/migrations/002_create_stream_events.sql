-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    label TEXT,
    state TEXT NOT NULL DEFAULT 'new',
    level INTEGER,
    rank INTEGER,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_rank ON stream_events (rank);
