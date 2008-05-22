-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    token TEXT,
    level INTEGER,
    weight REAL,
    ratio REAL,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_weight ON stream_events (weight);

INSERT INTO stream_events (token, level, weight, ratio, region) VALUES ('cached', 5, 67.66, 59.62, 'open');
INSERT INTO stream_events (token, level, weight, ratio, region) VALUES ('staging', 22, 42.01, 41.72, 'legacy');
