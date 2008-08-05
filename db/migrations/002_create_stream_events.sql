-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    count INTEGER NOT NULL DEFAULT 0,
    ratio REAL,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stream_events_rank ON stream_events (rank);

INSERT INTO stream_events (rank, count, ratio, score) VALUES (94, 34, 90.77, 67.05);
INSERT INTO stream_events (rank, count, ratio, score) VALUES (94, 92, 61.32, 19.07);
INSERT INTO stream_events (rank, count, ratio, score) VALUES (72, 49, 91.06, 90.46);
