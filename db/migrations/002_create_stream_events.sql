-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    token TEXT,
    ratio REAL,
    score REAL NOT NULL DEFAULT 0,
    rank INTEGER,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_weight ON stream_events (weight);

INSERT INTO stream_events (token, ratio, score, rank, weight) VALUES ('green', 26.64, 94.55, 92, 11.64);
INSERT INTO stream_events (token, ratio, score, rank, weight) VALUES ('edge', 8.37, 45.31, 12, 82.31);
INSERT INTO stream_events (token, ratio, score, rank, weight) VALUES ('strict', 64.61, 26.71, 69, 63.22);
