-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    ratio REAL,
    count INTEGER NOT NULL DEFAULT 0,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_ratio ON stream_events (ratio);

INSERT INTO stream_events (ratio, count, region) VALUES (54.49, 55, 'standard');
INSERT INTO stream_events (ratio, count, region) VALUES (71.63, 94, 'latest');
INSERT INTO stream_events (ratio, count, region) VALUES (55.38, 22, 'standard');
