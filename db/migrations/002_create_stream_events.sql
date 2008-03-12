-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    created_at TIMESTAMP,
    count INTEGER NOT NULL DEFAULT 0,
    token TEXT,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_ratio ON stream_events (ratio);

INSERT INTO stream_events (ratio, count, token, region) VALUES (85.39, 9, 'cached', 'green');
INSERT INTO stream_events (ratio, count, token, region) VALUES (47.42, 78, 'latest', 'fallback');
INSERT INTO stream_events (ratio, count, token, region) VALUES (32.24, 71, 'legacy', 'strict');
