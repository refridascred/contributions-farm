-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    token TEXT,
    score REAL NOT NULL DEFAULT 0,
    region TEXT,
    ratio REAL,
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_stream_events_token ON stream_events (token);

INSERT INTO stream_events (token, score, region, ratio) VALUES ('standard', 11.03, 'local', 90.15);
