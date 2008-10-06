-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    token TEXT,
    count INTEGER NOT NULL DEFAULT 0,
    weight REAL,
    region TEXT,
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_stream_events_token ON stream_events (token);

INSERT INTO stream_events (token, count, weight, region) VALUES ('fallback', 26, 77.05, 'eu-west');
INSERT INTO stream_events (token, count, weight, region) VALUES ('fallback', 8, 9.12, 'local');
