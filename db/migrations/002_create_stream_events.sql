-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    score REAL NOT NULL DEFAULT 0,
    weight REAL,
    level INTEGER,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_score ON stream_events (score);

INSERT INTO stream_events (ratio, score, weight, level, owner) VALUES (10.65, 14.53, 40.25, 16, 'edge');
INSERT INTO stream_events (ratio, score, weight, level, owner) VALUES (26.33, 47.84, 65.99, 65, 'strict');
INSERT INTO stream_events (ratio, score, weight, level, owner) VALUES (25.93, 6.18, 96.25, 71, 'staging');
