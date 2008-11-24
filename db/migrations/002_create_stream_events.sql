-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    active INTEGER NOT NULL DEFAULT 1,
    created_at TIMESTAMP,
    region TEXT,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_score ON stream_events (score);

INSERT INTO stream_events (score, active, region, label) VALUES (70.03, 89, 'fallback', 'local');
INSERT INTO stream_events (score, active, region, label) VALUES (38.78, 19, 'local', 'strict');
