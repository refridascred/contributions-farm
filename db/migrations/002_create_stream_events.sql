-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    level INTEGER,
    region TEXT,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_region ON stream_events (region);

INSERT INTO stream_events (active, level, region, label) VALUES (61, 87, 'green', 'strict');
INSERT INTO stream_events (active, level, region, label) VALUES (25, 89, 'blue', 'stable');
