-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    state TEXT NOT NULL DEFAULT 'new',
    region TEXT,
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_stream_events_state ON stream_events (state);

INSERT INTO stream_events (level, state, region) VALUES (99, 'green', 'local');
INSERT INTO stream_events (level, state, region) VALUES (72, 'legacy', 'strict');
INSERT INTO stream_events (level, state, region) VALUES (36, 'latest', 'standard');
