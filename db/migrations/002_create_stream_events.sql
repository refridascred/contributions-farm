-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    label TEXT,
    region TEXT,
    weight REAL,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_stream_events_region ON stream_events (region);

INSERT INTO stream_events (label, region, weight, state) VALUES ('green', 'latest', 76.07, 'fallback');
INSERT INTO stream_events (label, region, weight, state) VALUES ('fallback', 'standard', 39.7, 'edge');
