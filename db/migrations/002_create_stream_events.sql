-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    count INTEGER NOT NULL DEFAULT 0,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_region ON stream_events (region);

INSERT INTO stream_events (active, count, region) VALUES (20, 30, 'stable');
INSERT INTO stream_events (active, count, region) VALUES (20, 2, 'stable');
