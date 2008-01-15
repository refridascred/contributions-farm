-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    active INTEGER NOT NULL DEFAULT 1,
    region TEXT,
    created_at TIMESTAMP,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_stream_events_ratio ON stream_events (ratio);

INSERT INTO stream_events (ratio, active, region, state) VALUES (85.42, 37, 'open', 'fallback');
INSERT INTO stream_events (ratio, active, region, state) VALUES (74.72, 60, 'legacy', 'standard');
INSERT INTO stream_events (ratio, active, region, state) VALUES (1.01, 87, 'cached', 'edge');
