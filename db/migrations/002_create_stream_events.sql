-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    weight REAL,
    count INTEGER NOT NULL DEFAULT 0,
    ratio REAL,
    created_at TIMESTAMP,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stream_events_count ON stream_events (count);

INSERT INTO stream_events (weight, count, ratio, score) VALUES (39.46, 79, 44.36, 96.17);
INSERT INTO stream_events (weight, count, ratio, score) VALUES (96.67, 57, 40.22, 34.01);
INSERT INTO stream_events (weight, count, ratio, score) VALUES (42.43, 61, 73.44, 94.14);
