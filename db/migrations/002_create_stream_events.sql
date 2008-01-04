-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    region TEXT,
    ratio REAL,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_region ON stream_events (region);

INSERT INTO stream_events (region, ratio, label) VALUES ('stable', 50.71, 'latest');
INSERT INTO stream_events (region, ratio, label) VALUES ('standard', 37.97, 'primary');
INSERT INTO stream_events (region, ratio, label) VALUES ('staging', 24.17, 'stable');
