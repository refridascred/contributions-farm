-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    count INTEGER NOT NULL DEFAULT 0,
    token TEXT,
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_stream_events_ratio ON stream_events (ratio);

INSERT INTO stream_events (ratio, count, token) VALUES (61.46, 63, 'edge');
INSERT INTO stream_events (ratio, count, token) VALUES (13.72, 85, 'cached');
INSERT INTO stream_events (ratio, count, token) VALUES (22.74, 13, 'staging');
