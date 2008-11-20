-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    label TEXT,
    count INTEGER NOT NULL DEFAULT 0,
    weight REAL,
    ratio REAL,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_ratio ON stream_events (ratio);

INSERT INTO stream_events (label, count, weight, ratio, region) VALUES ('fallback', 67, 9.18, 51.75, 'edge');
INSERT INTO stream_events (label, count, weight, ratio, region) VALUES ('open', 1, 46.88, 80.79, 'primary');
INSERT INTO stream_events (label, count, weight, ratio, region) VALUES ('local', 5, 66.56, 37.15, 'primary');
