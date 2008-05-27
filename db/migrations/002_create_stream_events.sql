-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    token TEXT,
    region TEXT,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_stream_events_active ON stream_events (active);

INSERT INTO stream_events (level, token, region, active) VALUES (8, 'standard', 'standard', 95);
INSERT INTO stream_events (level, token, region, active) VALUES (5, 'standard', 'edge', 94);
INSERT INTO stream_events (level, token, region, active) VALUES (53, 'fallback', 'local', 97);
