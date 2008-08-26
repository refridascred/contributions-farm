-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    count INTEGER NOT NULL DEFAULT 0,
    ratio REAL,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stream_events_count ON stream_events (count);

INSERT INTO stream_events (rank, count, ratio, score) VALUES (66, 11, 34.5, 55.6);
INSERT INTO stream_events (rank, count, ratio, score) VALUES (35, 59, 82.15, 61.85);
INSERT INTO stream_events (rank, count, ratio, score) VALUES (11, 86, 46.76, 1.96);
