-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    weight REAL,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_weight ON stream_events (weight);

INSERT INTO stream_events (ratio, weight, region) VALUES (16.02, 31.1, 'legacy');
INSERT INTO stream_events (ratio, weight, region) VALUES (45.41, 22.69, 'standard');
