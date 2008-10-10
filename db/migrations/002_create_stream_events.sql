-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    state TEXT NOT NULL DEFAULT 'new',
    label TEXT,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_owner ON stream_events (owner);

INSERT INTO stream_events (owner, state, label, region) VALUES ('cached', 'stable', 'staging', 'latest');
INSERT INTO stream_events (owner, state, label, region) VALUES ('strict', 'latest', 'cached', 'edge');
