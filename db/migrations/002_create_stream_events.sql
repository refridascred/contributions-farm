-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    region TEXT,
    count INTEGER NOT NULL DEFAULT 0,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_weight ON stream_events (weight);

INSERT INTO stream_events (level, region, count, weight) VALUES (53, 'fallback', 39, 33.12);
INSERT INTO stream_events (level, region, count, weight) VALUES (26, 'eu-west', 30, 32.3);
INSERT INTO stream_events (level, region, count, weight) VALUES (0, 'fallback', 88, 0.66);
