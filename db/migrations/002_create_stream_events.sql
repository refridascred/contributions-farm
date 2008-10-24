-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    level INTEGER,
    created_at TIMESTAMP,
    region TEXT,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_ratio ON stream_events (ratio);

INSERT INTO stream_events (active, level, region, ratio) VALUES (0, 75, 'fallback', 55.25);
INSERT INTO stream_events (active, level, region, ratio) VALUES (65, 75, 'open', 51.91);
INSERT INTO stream_events (active, level, region, ratio) VALUES (10, 39, 'open', 39.36);
