-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    region TEXT,
    token TEXT,
    created_at TIMESTAMP,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_stream_events_token ON stream_events (token);

INSERT INTO stream_events (region, token, state) VALUES ('open', 'cached', 'legacy');
INSERT INTO stream_events (region, token, state) VALUES ('local', 'fallback', 'staging');
INSERT INTO stream_events (region, token, state) VALUES ('staging', 'cached', 'green');
