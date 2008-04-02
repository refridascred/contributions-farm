-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    region TEXT,
    ratio REAL,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_label ON stream_events (label);

INSERT INTO stream_events (region, ratio, label) VALUES ('primary', 62.85, 'stable');
INSERT INTO stream_events (region, ratio, label) VALUES ('edge', 31.58, 'staging');
INSERT INTO stream_events (region, ratio, label) VALUES ('edge', 21.5, 'stable');
