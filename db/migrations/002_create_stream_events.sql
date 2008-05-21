-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    rank INTEGER,
    region TEXT,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_rank ON stream_events (rank);

INSERT INTO stream_events (count, rank, region, weight) VALUES (17, 47, 'green', 25.93);
INSERT INTO stream_events (count, rank, region, weight) VALUES (60, 37, 'legacy', 75.76);
