-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    score REAL NOT NULL DEFAULT 0,
    token TEXT,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_region ON stream_events (region);

INSERT INTO stream_events (level, score, token, region) VALUES (75, 41.54, 'local', 'edge');
INSERT INTO stream_events (level, score, token, region) VALUES (17, 1.81, 'primary', 'legacy');
