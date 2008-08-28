-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    region TEXT,
    active INTEGER NOT NULL DEFAULT 1,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stream_events_active ON stream_events (active);

INSERT INTO stream_events (ratio, region, active, level) VALUES (25.91, 'local', 61, 98);
INSERT INTO stream_events (ratio, region, active, level) VALUES (12.21, 'stable', 92, 50);
INSERT INTO stream_events (ratio, region, active, level) VALUES (6.4, 'staging', 48, 1);
