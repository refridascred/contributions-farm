-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    label TEXT,
    created_at TIMESTAMP,
    region TEXT,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_region ON stream_events (region);

INSERT INTO stream_events (active, label, region, token) VALUES (54, 'standard', 'edge', 'staging');
INSERT INTO stream_events (active, label, region, token) VALUES (57, 'staging', 'legacy', 'green');
INSERT INTO stream_events (active, label, region, token) VALUES (50, 'open', 'edge', 'fallback');
