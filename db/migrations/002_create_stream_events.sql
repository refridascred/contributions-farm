-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    created_at TIMESTAMP,
    state TEXT NOT NULL DEFAULT 'new',
    active INTEGER NOT NULL DEFAULT 1,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_state ON stream_events (state);

INSERT INTO stream_events (level, state, active, region) VALUES (55, 'local', 81, 'strict');
INSERT INTO stream_events (level, state, active, region) VALUES (21, 'staging', 79, 'local');
INSERT INTO stream_events (level, state, active, region) VALUES (54, 'latest', 54, 'standard');
