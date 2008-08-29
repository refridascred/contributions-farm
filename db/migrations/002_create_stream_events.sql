-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    weight REAL,
    ratio REAL,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_region ON stream_events (region);

INSERT INTO stream_events (weight, ratio, region) VALUES (42.96, 51.08, 'edge');
INSERT INTO stream_events (weight, ratio, region) VALUES (6.83, 35.86, 'green');
INSERT INTO stream_events (weight, ratio, region) VALUES (41.75, 97.31, 'strict');
