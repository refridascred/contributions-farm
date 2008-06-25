-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    created_at TIMESTAMP,
    token TEXT,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stream_events_token ON stream_events (token);

INSERT INTO stream_events (ratio, token, count) VALUES (47.63, 'latest', 69);
INSERT INTO stream_events (ratio, token, count) VALUES (67.75, 'blue', 28);
INSERT INTO stream_events (ratio, token, count) VALUES (38.33, 'primary', 51);
