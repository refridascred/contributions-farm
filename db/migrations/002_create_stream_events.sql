-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    weight REAL,
    level INTEGER,
    count INTEGER NOT NULL DEFAULT 0,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_weight ON stream_events (weight);

INSERT INTO stream_events (weight, level, count, region) VALUES (0.95, 63, 19, 'stable');
INSERT INTO stream_events (weight, level, count, region) VALUES (27.37, 98, 10, 'fallback');
INSERT INTO stream_events (weight, level, count, region) VALUES (5.09, 31, 0, 'green');
