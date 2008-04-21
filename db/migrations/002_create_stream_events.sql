-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    weight REAL,
    level INTEGER,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_region ON stream_events (region);

INSERT INTO stream_events (weight, level, region) VALUES (24.49, 36, 'strict');
INSERT INTO stream_events (weight, level, region) VALUES (42.47, 39, 'blue');
