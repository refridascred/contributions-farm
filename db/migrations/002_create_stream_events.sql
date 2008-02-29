-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    region TEXT,
    token TEXT,
    count INTEGER NOT NULL DEFAULT 0,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stream_events_count ON stream_events (count);

INSERT INTO stream_events (region, token, count, score) VALUES ('blue', 'open', 90, 63.63);
INSERT INTO stream_events (region, token, count, score) VALUES ('primary', 'primary', 54, 77.5);
INSERT INTO stream_events (region, token, count, score) VALUES ('open', 'fallback', 38, 61.38);
