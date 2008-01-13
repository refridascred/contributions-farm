-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    ratio REAL,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stream_events_ratio ON stream_events (ratio);

INSERT INTO stream_events (score, ratio, count) VALUES (8.17, 70.36, 24);
INSERT INTO stream_events (score, ratio, count) VALUES (12.45, 34.32, 5);
INSERT INTO stream_events (score, ratio, count) VALUES (36.37, 83.12, 47);
