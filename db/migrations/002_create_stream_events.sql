-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    label TEXT,
    region TEXT,
    state TEXT NOT NULL DEFAULT 'new',
    owner TEXT NOT NULL,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_region ON stream_events (region);

INSERT INTO stream_events (label, region, state, owner, token) VALUES ('standard', 'fallback', 'staging', 'blue', 'green');
INSERT INTO stream_events (label, region, state, owner, token) VALUES ('green', 'green', 'latest', 'legacy', 'staging');
