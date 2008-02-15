-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    label TEXT,
    token TEXT,
    region TEXT,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stream_events_active ON stream_events (active);

INSERT INTO stream_events (active, label, token, region, rank) VALUES (34, 'eu-west', 'fallback', 'staging', 14);
INSERT INTO stream_events (active, label, token, region, rank) VALUES (12, 'standard', 'stable', 'edge', 31);
