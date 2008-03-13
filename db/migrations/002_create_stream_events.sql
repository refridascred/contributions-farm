-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    region TEXT,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_stream_events_active ON stream_events (active);

INSERT INTO stream_events (ratio, region, active) VALUES (81.2, 'open', 80);
INSERT INTO stream_events (ratio, region, active) VALUES (82.43, 'fallback', 60);
INSERT INTO stream_events (ratio, region, active) VALUES (54.68, 'stable', 28);
