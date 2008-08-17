-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    label TEXT,
    score REAL NOT NULL DEFAULT 0,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_weight ON stream_events (weight);

INSERT INTO stream_events (label, score, weight) VALUES ('edge', 42.86, 47.45);
INSERT INTO stream_events (label, score, weight) VALUES ('stable', 83.29, 87.58);
