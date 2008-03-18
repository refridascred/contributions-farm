-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    state TEXT NOT NULL DEFAULT 'new',
    region TEXT,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_state ON stream_events (state);

INSERT INTO stream_events (level, state, region, token) VALUES (18, 'stable', 'fallback', 'stable');
INSERT INTO stream_events (level, state, region, token) VALUES (11, 'strict', 'local', 'cached');
INSERT INTO stream_events (level, state, region, token) VALUES (68, 'edge', 'staging', 'blue');
