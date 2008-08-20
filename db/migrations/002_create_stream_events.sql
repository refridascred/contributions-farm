-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    label TEXT,
    state TEXT NOT NULL DEFAULT 'new',
    region TEXT,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_region ON stream_events (region);

INSERT INTO stream_events (owner, label, state, region, token) VALUES ('legacy', 'staging', 'legacy', 'blue', 'fallback');
INSERT INTO stream_events (owner, label, state, region, token) VALUES ('green', 'edge', 'primary', 'edge', 'edge');
INSERT INTO stream_events (owner, label, state, region, token) VALUES ('strict', 'staging', 'strict', 'eu-west', 'eu-west');
