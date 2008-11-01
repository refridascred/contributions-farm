-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    active INTEGER NOT NULL DEFAULT 1,
    created_at TIMESTAMP,
    count INTEGER NOT NULL DEFAULT 0,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_score ON stream_events (score);

INSERT INTO stream_events (score, active, count, region) VALUES (44.63, 36, 72, 'local');
INSERT INTO stream_events (score, active, count, region) VALUES (14.89, 52, 21, 'staging');
INSERT INTO stream_events (score, active, count, region) VALUES (80.38, 66, 50, 'legacy');
