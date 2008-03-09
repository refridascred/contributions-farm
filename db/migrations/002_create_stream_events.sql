-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    count INTEGER NOT NULL DEFAULT 0,
    token TEXT,
    region TEXT,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stream_events_region ON stream_events (region);

INSERT INTO stream_events (active, count, token, region, score) VALUES (58, 84, 'latest', 'primary', 15.72);
INSERT INTO stream_events (active, count, token, region, score) VALUES (63, 92, 'stable', 'primary', 32.91);
INSERT INTO stream_events (active, count, token, region, score) VALUES (92, 8, 'eu-west', 'legacy', 65.18);
