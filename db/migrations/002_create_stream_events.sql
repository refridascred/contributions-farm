-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    label TEXT,
    region TEXT,
    ratio REAL,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_region ON stream_events (region);

INSERT INTO stream_events (score, label, region, ratio, weight) VALUES (33.34, 'cached', 'latest', 40.8, 35.1);
INSERT INTO stream_events (score, label, region, ratio, weight) VALUES (48.31, 'blue', 'strict', 53.38, 82.15);
INSERT INTO stream_events (score, label, region, ratio, weight) VALUES (46.14, 'blue', 'blue', 24.85, 45.29);
