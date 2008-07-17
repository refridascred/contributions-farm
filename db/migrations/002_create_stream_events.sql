-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    label TEXT,
    owner TEXT NOT NULL,
    state TEXT NOT NULL DEFAULT 'new',
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_region ON stream_events (region);

INSERT INTO stream_events (label, owner, state, region) VALUES ('cached', 'strict', 'fallback', 'legacy');
INSERT INTO stream_events (label, owner, state, region) VALUES ('strict', 'open', 'strict', 'latest');
