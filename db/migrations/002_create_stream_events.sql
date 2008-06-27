-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    label TEXT,
    score REAL NOT NULL DEFAULT 0,
    region TEXT,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_weight ON stream_events (weight);

INSERT INTO stream_events (label, score, region, weight) VALUES ('local', 39.28, 'legacy', 15.01);
INSERT INTO stream_events (label, score, region, weight) VALUES ('green', 39.56, 'eu-west', 68.17);
