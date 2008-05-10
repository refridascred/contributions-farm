-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    label TEXT,
    ratio REAL,
    score REAL NOT NULL DEFAULT 0,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_score ON stream_events (score);

INSERT INTO stream_events (label, ratio, score, region) VALUES ('standard', 76.39, 33.58, 'cached');
INSERT INTO stream_events (label, ratio, score, region) VALUES ('stable', 93.18, 10.9, 'strict');
