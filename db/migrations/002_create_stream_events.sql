-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    token TEXT,
    region TEXT,
    weight REAL,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stream_events_weight ON stream_events (weight);

INSERT INTO stream_events (token, region, weight, score) VALUES ('fallback', 'primary', 37.88, 9.8);
INSERT INTO stream_events (token, region, weight, score) VALUES ('cached', 'stable', 20.63, 11.36);
INSERT INTO stream_events (token, region, weight, score) VALUES ('fallback', 'green', 37.15, 89.93);
