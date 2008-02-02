-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    score REAL NOT NULL DEFAULT 0,
    token TEXT,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stream_events_ratio ON stream_events (ratio);

INSERT INTO stream_events (ratio, score, token, level) VALUES (18.99, 94.48, 'edge', 29);
INSERT INTO stream_events (ratio, score, token, level) VALUES (34.61, 70.5, 'open', 32);
