-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    region TEXT,
    token TEXT,
    owner TEXT NOT NULL,
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_stream_events_token ON stream_events (token);

INSERT INTO stream_events (state, region, token, owner) VALUES ('fallback', 'local', 'fallback', 'fallback');
INSERT INTO stream_events (state, region, token, owner) VALUES ('legacy', 'local', 'latest', 'primary');
INSERT INTO stream_events (state, region, token, owner) VALUES ('staging', 'strict', 'blue', 'standard');
