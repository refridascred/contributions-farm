-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    weight REAL,
    score REAL NOT NULL DEFAULT 0,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_score ON stream_events (score);

INSERT INTO stream_events (ratio, weight, score, label) VALUES (97.54, 98.48, 26.25, 'local');
INSERT INTO stream_events (ratio, weight, score, label) VALUES (98.24, 79.45, 58.01, 'local');
