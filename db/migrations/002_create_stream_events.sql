-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    weight REAL,
    region TEXT,
    count INTEGER NOT NULL DEFAULT 0,
    label TEXT,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stream_events_score ON stream_events (score);

INSERT INTO stream_events (weight, region, count, label, score) VALUES (0.53, 'strict', 17, 'standard', 25.25);
INSERT INTO stream_events (weight, region, count, label, score) VALUES (27.97, 'edge', 9, 'blue', 12.93);
INSERT INTO stream_events (weight, region, count, label, score) VALUES (8.5, 'eu-west', 92, 'blue', 72.66);
