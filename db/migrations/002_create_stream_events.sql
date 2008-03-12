-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    ratio REAL,
    label TEXT,
    created_at TIMESTAMP,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_score ON stream_events (score);

INSERT INTO stream_events (score, ratio, label, region) VALUES (16.52, 72.81, 'blue', 'blue');
INSERT INTO stream_events (score, ratio, label, region) VALUES (18.83, 4.6, 'legacy', 'blue');
