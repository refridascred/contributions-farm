-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    region TEXT,
    state TEXT NOT NULL DEFAULT 'new',
    count INTEGER NOT NULL DEFAULT 0,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_region ON stream_events (region);

INSERT INTO stream_events (active, region, state, count, weight) VALUES (25, 'legacy', 'staging', 46, 35.81);
INSERT INTO stream_events (active, region, state, count, weight) VALUES (87, 'blue', 'edge', 22, 5.05);
INSERT INTO stream_events (active, region, state, count, weight) VALUES (90, 'blue', 'edge', 39, 4.07);
