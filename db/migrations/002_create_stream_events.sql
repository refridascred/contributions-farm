-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    token TEXT,
    created_at TIMESTAMP,
    score REAL NOT NULL DEFAULT 0,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_label ON stream_events (label);

INSERT INTO stream_events (count, token, score, label) VALUES (80, 'staging', 63.66, 'standard');
INSERT INTO stream_events (count, token, score, label) VALUES (65, 'standard', 36.28, 'cached');
INSERT INTO stream_events (count, token, score, label) VALUES (41, 'latest', 95.38, 'fallback');
