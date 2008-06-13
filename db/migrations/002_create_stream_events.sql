-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    score REAL NOT NULL DEFAULT 0,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_rank ON stream_events (rank);

INSERT INTO stream_events (rank, score, region) VALUES (47, 72.48, 'latest');
INSERT INTO stream_events (rank, score, region) VALUES (16, 12.83, 'edge');
INSERT INTO stream_events (rank, score, region) VALUES (61, 85.56, 'strict');
