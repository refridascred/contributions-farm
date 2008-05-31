-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    label TEXT,
    score REAL NOT NULL DEFAULT 0,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stream_events_score ON stream_events (score);

INSERT INTO stream_events (ratio, label, score, count) VALUES (39.87, 'standard', 76.8, 56);
INSERT INTO stream_events (ratio, label, score, count) VALUES (65.33, 'latest', 6.67, 46);
