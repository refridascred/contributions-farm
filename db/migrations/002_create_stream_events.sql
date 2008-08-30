-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    weight REAL,
    region TEXT,
    label TEXT,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stream_events_region ON stream_events (region);

INSERT INTO stream_events (weight, region, label, level) VALUES (12.61, 'stable', 'primary', 54);
INSERT INTO stream_events (weight, region, label, level) VALUES (29.08, 'local', 'staging', 54);
INSERT INTO stream_events (weight, region, label, level) VALUES (62.89, 'standard', 'standard', 52);
