-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    label TEXT,
    score REAL NOT NULL DEFAULT 0,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_score ON stream_events (score);

INSERT INTO stream_events (label, score, token) VALUES ('fallback', 88.78, 'cached');
INSERT INTO stream_events (label, score, token) VALUES ('eu-west', 56.12, 'latest');
