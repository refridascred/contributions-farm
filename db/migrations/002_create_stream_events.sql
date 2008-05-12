-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    weight REAL,
    region TEXT,
    ratio REAL,
    token TEXT,
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_stream_events_ratio ON stream_events (ratio);

INSERT INTO stream_events (weight, region, ratio, token) VALUES (32.94, 'standard', 48.95, 'latest');
INSERT INTO stream_events (weight, region, ratio, token) VALUES (49.02, 'standard', 50.04, 'eu-west');
INSERT INTO stream_events (weight, region, ratio, token) VALUES (54.64, 'fallback', 13.2, 'standard');
