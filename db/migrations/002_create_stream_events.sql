-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    ratio REAL,
    score REAL NOT NULL DEFAULT 0,
    token TEXT,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stream_events_token ON stream_events (token);

INSERT INTO stream_events (level, ratio, score, token, count) VALUES (93, 11.73, 78.19, 'blue', 16);
INSERT INTO stream_events (level, ratio, score, token, count) VALUES (75, 66.42, 50.36, 'strict', 22);
INSERT INTO stream_events (level, ratio, score, token, count) VALUES (92, 85.02, 90.8, 'edge', 11);
