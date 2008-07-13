-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    created_at TIMESTAMP,
    region TEXT,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_token ON stream_events (token);

INSERT INTO stream_events (state, region, token) VALUES ('staging', 'cached', 'eu-west');
INSERT INTO stream_events (state, region, token) VALUES ('edge', 'green', 'standard');
