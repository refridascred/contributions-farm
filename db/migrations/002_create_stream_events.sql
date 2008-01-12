-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    count INTEGER NOT NULL DEFAULT 0,
    region TEXT,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_stream_events_active ON stream_events (active);

INSERT INTO stream_events (count, region, active) VALUES (82, 'fallback', 27);
INSERT INTO stream_events (count, region, active) VALUES (45, 'legacy', 58);
INSERT INTO stream_events (count, region, active) VALUES (26, 'edge', 94);
