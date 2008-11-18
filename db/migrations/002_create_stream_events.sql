-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    label TEXT,
    level INTEGER,
    region TEXT,
    weight REAL,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stream_events_weight ON stream_events (weight);

INSERT INTO stream_events (label, level, region, weight, score) VALUES ('local', 59, 'edge', 86.69, 59.11);
INSERT INTO stream_events (label, level, region, weight, score) VALUES ('edge', 55, 'edge', 67.2, 95.51);
INSERT INTO stream_events (label, level, region, weight, score) VALUES ('eu-west', 17, 'green', 37.24, 29.5);
