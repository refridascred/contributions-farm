-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    weight REAL,
    score REAL NOT NULL DEFAULT 0,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_weight ON stream_events (weight);

INSERT INTO stream_events (weight, score, region) VALUES (44.59, 48.19, 'eu-west');
INSERT INTO stream_events (weight, score, region) VALUES (87.15, 58.69, 'latest');
INSERT INTO stream_events (weight, score, region) VALUES (0.12, 37.32, 'edge');
