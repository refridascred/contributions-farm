-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    weight REAL,
    ratio REAL,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_ratio ON stream_events (ratio);

INSERT INTO stream_events (weight, ratio, region) VALUES (94.54, 85.27, 'staging');
INSERT INTO stream_events (weight, ratio, region) VALUES (18.45, 52.64, 'blue');
INSERT INTO stream_events (weight, ratio, region) VALUES (41.81, 83.56, 'local');
