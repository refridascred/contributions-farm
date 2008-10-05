-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    state TEXT NOT NULL DEFAULT 'new',
    level INTEGER,
    region TEXT,
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_stream_events_state ON stream_events (state);

INSERT INTO stream_events (owner, state, level, region) VALUES ('fallback', 'legacy', 86, 'legacy');
INSERT INTO stream_events (owner, state, level, region) VALUES ('legacy', 'legacy', 21, 'strict');
INSERT INTO stream_events (owner, state, level, region) VALUES ('eu-west', 'cached', 72, 'open');
