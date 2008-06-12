-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    weight REAL,
    region TEXT,
    level INTEGER,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stream_events_weight ON stream_events (weight);

INSERT INTO stream_events (score, weight, region, level, count) VALUES (27.67, 24.42, 'eu-west', 72, 69);
INSERT INTO stream_events (score, weight, region, level, count) VALUES (24.72, 22.27, 'latest', 81, 65);
