-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    label TEXT,
    token TEXT,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stream_events_score ON stream_events (score);

INSERT INTO stream_events (label, token, score) VALUES ('primary', 'eu-west', 48.42);
INSERT INTO stream_events (label, token, score) VALUES ('fallback', 'edge', 0.24);
