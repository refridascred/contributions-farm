-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    region TEXT,
    label TEXT,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_stream_events_region ON stream_events (region);

INSERT INTO stream_events (score, region, label, state) VALUES (58.99, 'standard', 'cached', 'primary');
INSERT INTO stream_events (score, region, label, state) VALUES (24.53, 'cached', 'primary', 'latest');
INSERT INTO stream_events (score, region, label, state) VALUES (79.52, 'staging', 'latest', 'staging');
