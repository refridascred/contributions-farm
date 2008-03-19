-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    rank INTEGER,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_rank ON stream_events (rank);

INSERT INTO stream_events (active, rank, region) VALUES (65, 70, 'strict');
INSERT INTO stream_events (active, rank, region) VALUES (16, 10, 'legacy');
INSERT INTO stream_events (active, rank, region) VALUES (42, 55, 'fallback');
