-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    score REAL NOT NULL DEFAULT 0,
    token TEXT,
    region TEXT,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stream_events_region ON stream_events (region);

INSERT INTO stream_events (active, score, token, region, count) VALUES (58, 79.04, 'cached', 'strict', 21);
INSERT INTO stream_events (active, score, token, region, count) VALUES (79, 5.31, 'cached', 'green', 25);
