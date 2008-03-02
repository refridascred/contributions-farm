-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    weight REAL,
    score REAL NOT NULL DEFAULT 0,
    region TEXT,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stream_events_region ON stream_events (region);

INSERT INTO stream_events (count, weight, score, region, level) VALUES (36, 43.02, 60.6, 'green', 23);
INSERT INTO stream_events (count, weight, score, region, level) VALUES (46, 89.92, 34.04, 'eu-west', 49);
INSERT INTO stream_events (count, weight, score, region, level) VALUES (86, 29.05, 17.96, 'stable', 91);
