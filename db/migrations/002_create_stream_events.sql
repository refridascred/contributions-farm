-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    weight REAL,
    score REAL NOT NULL DEFAULT 0,
    region TEXT,
    ratio REAL,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stream_events_ratio ON stream_events (ratio);

INSERT INTO stream_events (weight, score, region, ratio, count) VALUES (75.39, 22.68, 'fallback', 80.82, 27);
INSERT INTO stream_events (weight, score, region, ratio, count) VALUES (64.41, 19.17, 'local', 37.3, 84);
INSERT INTO stream_events (weight, score, region, ratio, count) VALUES (87.32, 42.65, 'strict', 42.76, 39);
