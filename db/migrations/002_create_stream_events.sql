-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    weight REAL,
    region TEXT,
    score REAL NOT NULL DEFAULT 0,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_score ON stream_events (score);

INSERT INTO stream_events (weight, region, score, token) VALUES (97.42, 'blue', 93.35, 'standard');
INSERT INTO stream_events (weight, region, score, token) VALUES (21.52, 'green', 41.1, 'cached');
INSERT INTO stream_events (weight, region, score, token) VALUES (49.38, 'local', 77.75, 'cached');
