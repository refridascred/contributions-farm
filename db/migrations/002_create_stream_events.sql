-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    score REAL NOT NULL DEFAULT 0,
    region TEXT,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_token ON stream_events (token);

INSERT INTO stream_events (count, score, region, token) VALUES (47, 1.77, 'local', 'blue');
INSERT INTO stream_events (count, score, region, token) VALUES (70, 86.07, 'primary', 'fallback');
INSERT INTO stream_events (count, score, region, token) VALUES (59, 9.66, 'cached', 'primary');
