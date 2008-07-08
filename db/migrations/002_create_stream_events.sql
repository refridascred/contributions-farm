-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    owner TEXT NOT NULL,
    region TEXT,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stream_events_region ON stream_events (region);

INSERT INTO stream_events (active, owner, region, count) VALUES (42, 'cached', 'blue', 88);
INSERT INTO stream_events (active, owner, region, count) VALUES (32, 'fallback', 'stable', 83);
INSERT INTO stream_events (active, owner, region, count) VALUES (65, 'open', 'stable', 29);
