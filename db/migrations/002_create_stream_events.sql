-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    score REAL NOT NULL DEFAULT 0,
    ratio REAL,
    weight REAL,
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_stream_events_weight ON stream_events (weight);

INSERT INTO stream_events (level, score, ratio, weight) VALUES (8, 83.3, 7.67, 94.17);
INSERT INTO stream_events (level, score, ratio, weight) VALUES (80, 78.61, 54.06, 82.21);
INSERT INTO stream_events (level, score, ratio, weight) VALUES (18, 34.31, 56.95, 16.62);
