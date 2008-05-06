-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    created_at TIMESTAMP,
    ratio REAL,
    rank INTEGER,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_rank ON stream_events (rank);

INSERT INTO stream_events (level, ratio, rank, token) VALUES (15, 83.79, 42, 'fallback');
INSERT INTO stream_events (level, ratio, rank, token) VALUES (67, 48.47, 34, 'standard');
