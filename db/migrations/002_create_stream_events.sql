-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    token TEXT,
    weight REAL,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_weight ON stream_events (weight);

INSERT INTO stream_events (level, token, weight, region) VALUES (28, 'local', 63.79, 'fallback');
INSERT INTO stream_events (level, token, weight, region) VALUES (43, 'standard', 47.55, 'stable');
