-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    weight REAL,
    score REAL NOT NULL DEFAULT 0,
    token TEXT,
    label TEXT,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_score ON stream_events (score);

INSERT INTO stream_events (weight, score, token, label, region) VALUES (26.46, 79.76, 'fallback', 'open', 'green');
INSERT INTO stream_events (weight, score, token, label, region) VALUES (98.65, 34.01, 'green', 'latest', 'staging');
INSERT INTO stream_events (weight, score, token, label, region) VALUES (25.22, 18.74, 'stable', 'cached', 'standard');
