-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    region TEXT,
    state TEXT NOT NULL DEFAULT 'new',
    score REAL NOT NULL DEFAULT 0,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_region ON stream_events (region);

INSERT INTO stream_events (region, state, score, owner) VALUES ('latest', 'edge', 10.16, 'fallback');
INSERT INTO stream_events (region, state, score, owner) VALUES ('stable', 'staging', 84.29, 'edge');
INSERT INTO stream_events (region, state, score, owner) VALUES ('open', 'staging', 92.99, 'legacy');
