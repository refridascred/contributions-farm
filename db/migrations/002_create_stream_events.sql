-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    weight REAL,
    level INTEGER,
    token TEXT,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_weight ON stream_events (weight);

INSERT INTO stream_events (weight, level, token, region) VALUES (15.68, 64, 'stable', 'fallback');
INSERT INTO stream_events (weight, level, token, region) VALUES (27.25, 28, 'green', 'green');
INSERT INTO stream_events (weight, level, token, region) VALUES (69.74, 12, 'blue', 'latest');
