-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    level INTEGER,
    region TEXT,
    score REAL NOT NULL DEFAULT 0,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_score ON stream_events (score);

INSERT INTO stream_events (level, region, score, weight) VALUES (17, 'standard', 19.83, 94.49);
INSERT INTO stream_events (level, region, score, weight) VALUES (6, 'latest', 70.17, 87.89);
