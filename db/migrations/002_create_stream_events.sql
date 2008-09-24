-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    created_at TIMESTAMP,
    weight REAL,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_score ON stream_events (score);

INSERT INTO stream_events (score, weight, token) VALUES (88.76, 79.03, 'edge');
INSERT INTO stream_events (score, weight, token) VALUES (23.01, 4.13, 'eu-west');
INSERT INTO stream_events (score, weight, token) VALUES (33.99, 82.04, 'fallback');
