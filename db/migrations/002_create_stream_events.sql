-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    region TEXT,
    active INTEGER NOT NULL DEFAULT 1,
    weight REAL,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_ratio ON stream_events (ratio);

INSERT INTO stream_events (score, region, active, weight, ratio) VALUES (43.59, 'standard', 36, 49.04, 70.9);
INSERT INTO stream_events (score, region, active, weight, ratio) VALUES (85.25, 'latest', 41, 71.48, 60.69);
INSERT INTO stream_events (score, region, active, weight, ratio) VALUES (97.65, 'strict', 64, 41.9, 27.77);
