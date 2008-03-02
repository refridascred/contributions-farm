-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    score REAL NOT NULL DEFAULT 0,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stream_events_score ON stream_events (score);

INSERT INTO stream_events (ratio, score, level) VALUES (4.01, 95.31, 33);
INSERT INTO stream_events (ratio, score, level) VALUES (61.8, 49.05, 96);
