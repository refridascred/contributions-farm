-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    label TEXT,
    region TEXT,
    ratio REAL,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_ratio ON stream_events (ratio);

INSERT INTO stream_events (count, label, region, ratio, token) VALUES (50, 'stable', 'stable', 71.89, 'green');
INSERT INTO stream_events (count, label, region, ratio, token) VALUES (1, 'fallback', 'edge', 74.41, 'eu-west');
INSERT INTO stream_events (count, label, region, ratio, token) VALUES (51, 'standard', 'primary', 29.81, 'primary');
