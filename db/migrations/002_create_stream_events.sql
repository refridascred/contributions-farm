-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    weight REAL,
    ratio REAL,
    count INTEGER NOT NULL DEFAULT 0,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_region ON stream_events (region);

INSERT INTO stream_events (weight, ratio, count, region) VALUES (39.7, 89.78, 9, 'local');
INSERT INTO stream_events (weight, ratio, count, region) VALUES (32.29, 72.3, 44, 'staging');
INSERT INTO stream_events (weight, ratio, count, region) VALUES (25.5, 97.54, 0, 'primary');
