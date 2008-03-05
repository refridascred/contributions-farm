-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    region TEXT,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stream_events_region ON stream_events (region);

INSERT INTO stream_events (ratio, region, level) VALUES (65.01, 'edge', 16);
INSERT INTO stream_events (ratio, region, level) VALUES (0.54, 'cached', 23);
