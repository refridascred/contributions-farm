-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    label TEXT,
    active INTEGER NOT NULL DEFAULT 1,
    region TEXT,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stream_events_region ON stream_events (region);

INSERT INTO stream_events (score, label, active, region, count) VALUES (42.66, 'strict', 19, 'staging', 15);
INSERT INTO stream_events (score, label, active, region, count) VALUES (82.94, 'cached', 0, 'primary', 37);
