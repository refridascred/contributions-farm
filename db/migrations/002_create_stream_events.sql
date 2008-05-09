-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    region TEXT,
    state TEXT NOT NULL DEFAULT 'new',
    weight REAL,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stream_events_region ON stream_events (region);

INSERT INTO stream_events (region, state, weight, level) VALUES ('primary', 'edge', 94.59, 86);
INSERT INTO stream_events (region, state, weight, level) VALUES ('primary', 'edge', 89.37, 20);
