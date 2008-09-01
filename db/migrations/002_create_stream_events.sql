-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    ratio REAL,
    score REAL NOT NULL DEFAULT 0,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_weight ON stream_events (weight);

INSERT INTO stream_events (count, ratio, score, weight) VALUES (89, 73.38, 4.08, 21.6);
INSERT INTO stream_events (count, ratio, score, weight) VALUES (86, 95.8, 53.38, 22.86);
