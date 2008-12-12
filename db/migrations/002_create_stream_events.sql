-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    region TEXT,
    ratio REAL,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_region ON stream_events (region);

INSERT INTO stream_events (region, ratio, label) VALUES ('primary', 15.2, 'local');
INSERT INTO stream_events (region, ratio, label) VALUES ('staging', 6.84, 'latest');
