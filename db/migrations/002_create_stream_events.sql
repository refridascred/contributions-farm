-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    region TEXT,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stream_events_level ON stream_events (level);

INSERT INTO stream_events (score, region, level) VALUES (94.71, 'fallback', 34);
INSERT INTO stream_events (score, region, level) VALUES (48.13, 'strict', 57);
INSERT INTO stream_events (score, region, level) VALUES (86.09, 'open', 86);
