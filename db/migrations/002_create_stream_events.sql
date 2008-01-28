-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    score REAL NOT NULL DEFAULT 0,
    rank INTEGER,
    region TEXT,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_rank ON stream_events (rank);

INSERT INTO stream_events (score, rank, region, weight) VALUES (22.07, 65, 'legacy', 99.0);
INSERT INTO stream_events (score, rank, region, weight) VALUES (37.67, 74, 'blue', 6.69);
INSERT INTO stream_events (score, rank, region, weight) VALUES (6.72, 63, 'green', 19.83);
