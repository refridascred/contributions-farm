-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    ratio REAL,
    weight REAL,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_active ON stream_events (active);

INSERT INTO stream_events (active, ratio, weight, region) VALUES (74, 86.04, 40.69, 'primary');
INSERT INTO stream_events (active, ratio, weight, region) VALUES (98, 60.73, 42.81, 'stable');
