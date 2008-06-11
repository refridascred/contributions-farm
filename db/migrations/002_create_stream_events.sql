-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    weight REAL,
    ratio REAL,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_region ON stream_events (region);

INSERT INTO stream_events (weight, ratio, region) VALUES (53.87, 11.81, 'strict');
INSERT INTO stream_events (weight, ratio, region) VALUES (42.56, 27.43, 'standard');
INSERT INTO stream_events (weight, ratio, region) VALUES (15.88, 40.7, 'blue');
