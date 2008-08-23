-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    weight REAL,
    active INTEGER NOT NULL DEFAULT 1,
    region TEXT,
    count INTEGER NOT NULL DEFAULT 0,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_stream_events_region ON stream_events (region);

INSERT INTO stream_events (weight, active, region, count, state) VALUES (21.24, 87, 'standard', 32, 'stable');
INSERT INTO stream_events (weight, active, region, count, state) VALUES (9.68, 82, 'fallback', 55, 'legacy');
