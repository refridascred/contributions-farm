-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    label TEXT,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_region ON stream_events (region);

INSERT INTO stream_events (ratio, label, region) VALUES (65.78, 'stable', 'eu-west');
INSERT INTO stream_events (ratio, label, region) VALUES (87.97, 'cached', 'edge');
