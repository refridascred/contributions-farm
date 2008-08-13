-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    token TEXT,
    created_at TIMESTAMP,
    active INTEGER NOT NULL DEFAULT 1,
    score REAL NOT NULL DEFAULT 0,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_created_at ON stream_events (created_at);

INSERT INTO stream_events (token, active, score, region) VALUES ('green', 99, 18.03, 'staging');
INSERT INTO stream_events (token, active, score, region) VALUES ('edge', 85, 85.03, 'edge');
INSERT INTO stream_events (token, active, score, region) VALUES ('edge', 90, 47.01, 'primary');
