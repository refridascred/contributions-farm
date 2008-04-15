-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    weight REAL,
    active INTEGER NOT NULL DEFAULT 1,
    score REAL NOT NULL DEFAULT 0,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_weight ON stream_events (weight);

INSERT INTO stream_events (weight, active, score, ratio) VALUES (67.68, 40, 98.32, 82.2);
INSERT INTO stream_events (weight, active, score, ratio) VALUES (0.12, 70, 54.08, 85.72);
