-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    count INTEGER NOT NULL DEFAULT 0,
    level INTEGER,
    weight REAL,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_weight ON stream_events (weight);

INSERT INTO stream_events (active, count, level, weight, region) VALUES (21, 56, 12, 57.45, 'stable');
INSERT INTO stream_events (active, count, level, weight, region) VALUES (96, 57, 78, 89.0, 'edge');
INSERT INTO stream_events (active, count, level, weight, region) VALUES (20, 99, 43, 34.59, 'primary');
