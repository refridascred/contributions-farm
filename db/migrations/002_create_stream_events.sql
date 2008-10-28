-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    token TEXT,
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_stream_events_ratio ON stream_events (ratio);

INSERT INTO stream_events (ratio, token) VALUES (62.3, 'stable');
INSERT INTO stream_events (ratio, token) VALUES (16.06, 'latest');
INSERT INTO stream_events (ratio, token) VALUES (24.71, 'cached');
