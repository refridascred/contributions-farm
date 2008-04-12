-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    token TEXT,
    count INTEGER NOT NULL DEFAULT 0,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_token ON stream_events (token);

INSERT INTO stream_events (score, token, count, region) VALUES (88.55, 'edge', 67, 'primary');
INSERT INTO stream_events (score, token, count, region) VALUES (95.53, 'strict', 20, 'stable');
