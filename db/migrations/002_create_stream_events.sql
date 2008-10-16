-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    token TEXT,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_state ON stream_events (state);

INSERT INTO stream_events (state, token, region) VALUES ('local', 'staging', 'eu-west');
INSERT INTO stream_events (state, token, region) VALUES ('edge', 'latest', 'strict');
INSERT INTO stream_events (state, token, region) VALUES ('latest', 'fallback', 'eu-west');
