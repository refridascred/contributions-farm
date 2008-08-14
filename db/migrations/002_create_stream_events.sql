-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    region TEXT,
    active INTEGER NOT NULL DEFAULT 1,
    state TEXT NOT NULL DEFAULT 'new',
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_region ON stream_events (region);

INSERT INTO stream_events (owner, region, active, state, token) VALUES ('local', 'local', 64, 'fallback', 'latest');
INSERT INTO stream_events (owner, region, active, state, token) VALUES ('stable', 'local', 26, 'strict', 'cached');
INSERT INTO stream_events (owner, region, active, state, token) VALUES ('legacy', 'primary', 89, 'edge', 'latest');
