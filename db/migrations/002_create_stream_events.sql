-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    state TEXT NOT NULL DEFAULT 'new',
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_state ON stream_events (state);

INSERT INTO stream_events (owner, state, region) VALUES ('staging', 'local', 'blue');
INSERT INTO stream_events (owner, state, region) VALUES ('edge', 'green', 'primary');
INSERT INTO stream_events (owner, state, region) VALUES ('fallback', 'primary', 'local');
