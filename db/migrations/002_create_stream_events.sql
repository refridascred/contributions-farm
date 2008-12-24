-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    count INTEGER NOT NULL DEFAULT 0,
    weight REAL,
    rank INTEGER,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_rank ON stream_events (rank);

INSERT INTO stream_events (active, count, weight, rank, ratio) VALUES (90, 76, 75.49, 26, 89.47);
INSERT INTO stream_events (active, count, weight, rank, ratio) VALUES (25, 18, 70.44, 61, 97.99);
