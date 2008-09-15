-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    ratio REAL,
    level INTEGER,
    weight REAL,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_weight ON stream_events (weight);

INSERT INTO stream_events (score, ratio, level, weight, label) VALUES (17.58, 86.17, 47, 72.45, 'fallback');
INSERT INTO stream_events (score, ratio, level, weight, label) VALUES (48.62, 55.96, 21, 77.48, 'staging');
