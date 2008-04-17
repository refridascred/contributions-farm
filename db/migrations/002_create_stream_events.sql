-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    region TEXT,
    count INTEGER NOT NULL DEFAULT 0,
    created_at TIMESTAMP,
    score REAL NOT NULL DEFAULT 0,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_score ON stream_events (score);

INSERT INTO stream_events (region, count, score, label) VALUES ('cached', 36, 32.7, 'standard');
INSERT INTO stream_events (region, count, score, label) VALUES ('fallback', 66, 36.49, 'eu-west');
INSERT INTO stream_events (region, count, score, label) VALUES ('eu-west', 99, 0.9, 'cached');
