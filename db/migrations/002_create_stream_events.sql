-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    weight REAL,
    score REAL NOT NULL DEFAULT 0,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stream_events_count ON stream_events (count);

INSERT INTO stream_events (weight, score, count) VALUES (96.25, 79.59, 9);
INSERT INTO stream_events (weight, score, count) VALUES (59.18, 85.57, 59);
INSERT INTO stream_events (weight, score, count) VALUES (74.25, 81.13, 25);
