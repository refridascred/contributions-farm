-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    state TEXT NOT NULL DEFAULT 'new',
    region TEXT,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stream_events_rank ON stream_events (rank);

INSERT INTO stream_events (ratio, state, region, rank) VALUES (56.91, 'green', 'latest', 45);
INSERT INTO stream_events (ratio, state, region, rank) VALUES (85.44, 'latest', 'cached', 85);
