-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    state TEXT NOT NULL DEFAULT 'new',
    region TEXT,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_region ON stream_events (region);

INSERT INTO stream_events (score, state, region, label) VALUES (16.35, 'legacy', 'fallback', 'staging');
INSERT INTO stream_events (score, state, region, label) VALUES (44.98, 'latest', 'fallback', 'latest');
