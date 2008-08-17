-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    state TEXT NOT NULL DEFAULT 'new',
    owner TEXT NOT NULL,
    token TEXT,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_token ON stream_events (token);

INSERT INTO stream_events (state, owner, token, region) VALUES ('blue', 'primary', 'legacy', 'staging');
INSERT INTO stream_events (state, owner, token, region) VALUES ('edge', 'legacy', 'primary', 'strict');
