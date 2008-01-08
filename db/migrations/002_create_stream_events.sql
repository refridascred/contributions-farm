-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    weight REAL,
    region TEXT,
    rank INTEGER,
    count INTEGER NOT NULL DEFAULT 0,
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_stream_events_rank ON stream_events (rank);

INSERT INTO stream_events (weight, region, rank, count) VALUES (74.18, 'stable', 24, 57);
INSERT INTO stream_events (weight, region, rank, count) VALUES (52.15, 'cached', 90, 99);
INSERT INTO stream_events (weight, region, rank, count) VALUES (81.57, 'blue', 26, 52);
