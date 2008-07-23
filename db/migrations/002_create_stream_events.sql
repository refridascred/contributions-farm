-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    weight REAL,
    active INTEGER NOT NULL DEFAULT 1,
    level INTEGER,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_region ON stream_events (region);

INSERT INTO stream_events (weight, active, level, region) VALUES (55.22, 13, 10, 'edge');
INSERT INTO stream_events (weight, active, level, region) VALUES (62.74, 73, 62, 'staging');
