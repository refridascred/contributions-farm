-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    token TEXT,
    label TEXT,
    region TEXT,
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_stream_events_score ON stream_events (score);

INSERT INTO stream_events (score, token, label, region) VALUES (18.69, 'cached', 'edge', 'latest');
INSERT INTO stream_events (score, token, label, region) VALUES (62.58, 'local', 'local', 'stable');
