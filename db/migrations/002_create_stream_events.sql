-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    token TEXT,
    region TEXT,
    rank INTEGER,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stream_events_count ON stream_events (count);

INSERT INTO stream_events (score, token, region, rank, count) VALUES (97.45, 'primary', 'primary', 80, 9);
INSERT INTO stream_events (score, token, region, rank, count) VALUES (93.54, 'standard', 'fallback', 84, 38);
