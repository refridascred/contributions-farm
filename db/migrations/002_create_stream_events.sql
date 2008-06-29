-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    ratio REAL,
    active INTEGER NOT NULL DEFAULT 1,
    weight REAL,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stream_events_weight ON stream_events (weight);

INSERT INTO stream_events (count, ratio, active, weight, score) VALUES (36, 25.08, 64, 75.3, 46.71);
INSERT INTO stream_events (count, ratio, active, weight, score) VALUES (37, 72.16, 22, 71.07, 45.04);
