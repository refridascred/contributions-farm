-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    state TEXT NOT NULL DEFAULT 'new',
    weight REAL,
    owner TEXT NOT NULL,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_state ON stream_events (state);

INSERT INTO stream_events (active, state, weight, owner, region) VALUES (40, 'staging', 71.35, 'green', 'staging');
INSERT INTO stream_events (active, state, weight, owner, region) VALUES (80, 'latest', 89.1, 'green', 'edge');
INSERT INTO stream_events (active, state, weight, owner, region) VALUES (60, 'fallback', 73.19, 'strict', 'legacy');
