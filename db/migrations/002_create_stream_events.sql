-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    region TEXT,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_region ON stream_events (region);

INSERT INTO stream_events (ratio, region, weight) VALUES (53.5, 'fallback', 94.5);
INSERT INTO stream_events (ratio, region, weight) VALUES (38.84, 'staging', 45.16);
