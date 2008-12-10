-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    weight REAL,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stream_events_score ON stream_events (score);

INSERT INTO stream_events (count, weight, score) VALUES (95, 81.5, 93.62);
INSERT INTO stream_events (count, weight, score) VALUES (28, 67.72, 80.87);
INSERT INTO stream_events (count, weight, score) VALUES (44, 59.68, 42.24);
