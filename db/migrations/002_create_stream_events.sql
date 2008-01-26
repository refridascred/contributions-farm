-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    region TEXT,
    token TEXT,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_region ON stream_events (region);

INSERT INTO stream_events (active, region, token, ratio) VALUES (47, 'open', 'stable', 39.5);
INSERT INTO stream_events (active, region, token, ratio) VALUES (56, 'standard', 'staging', 30.19);
