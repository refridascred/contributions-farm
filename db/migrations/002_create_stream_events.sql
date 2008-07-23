-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    region TEXT,
    count INTEGER NOT NULL DEFAULT 0,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_score ON stream_events (score);

INSERT INTO stream_events (score, region, count, token) VALUES (42.89, 'legacy', 68, 'fallback');
INSERT INTO stream_events (score, region, count, token) VALUES (42.29, 'edge', 37, 'blue');
INSERT INTO stream_events (score, region, count, token) VALUES (86.97, 'legacy', 65, 'blue');
