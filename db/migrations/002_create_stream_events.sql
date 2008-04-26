-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    created_at TIMESTAMP,
    level INTEGER,
    region TEXT,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_stream_events_created_at ON stream_events (created_at);

INSERT INTO stream_events (ratio, level, region, active) VALUES (92.22, 81, 'standard', 20);
INSERT INTO stream_events (ratio, level, region, active) VALUES (3.55, 68, 'edge', 48);
INSERT INTO stream_events (ratio, level, region, active) VALUES (7.51, 10, 'standard', 57);
