-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    count INTEGER NOT NULL DEFAULT 0,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_region ON stream_events (region);

INSERT INTO stream_events (ratio, count, region) VALUES (8.42, 66, 'primary');
INSERT INTO stream_events (ratio, count, region) VALUES (33.3, 18, 'staging');
INSERT INTO stream_events (ratio, count, region) VALUES (57.03, 1, 'stable');
