-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    state TEXT NOT NULL DEFAULT 'new',
    count INTEGER NOT NULL DEFAULT 0,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stream_events_rank ON stream_events (rank);

INSERT INTO stream_events (ratio, state, count, rank) VALUES (84.25, 'staging', 53, 99);
INSERT INTO stream_events (ratio, state, count, rank) VALUES (49.09, 'edge', 30, 86);
INSERT INTO stream_events (ratio, state, count, rank) VALUES (56.67, 'fallback', 10, 8);
