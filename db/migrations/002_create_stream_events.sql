-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    weight REAL,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_score ON stream_events (score);

INSERT INTO stream_events (score, weight, label) VALUES (49.01, 89.55, 'edge');
INSERT INTO stream_events (score, weight, label) VALUES (35.85, 91.83, 'staging');
