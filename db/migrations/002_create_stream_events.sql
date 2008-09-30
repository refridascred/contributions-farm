-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    created_at TIMESTAMP,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_ratio ON stream_events (ratio);

INSERT INTO stream_events (ratio, region) VALUES (94.8, 'stable');
INSERT INTO stream_events (ratio, region) VALUES (32.52, 'primary');
INSERT INTO stream_events (ratio, region) VALUES (16.57, 'cached');
