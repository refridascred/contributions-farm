-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    token TEXT,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stream_events_token ON stream_events (token);

INSERT INTO stream_events (state, token, level) VALUES ('legacy', 'primary', 41);
INSERT INTO stream_events (state, token, level) VALUES ('blue', 'latest', 12);
INSERT INTO stream_events (state, token, level) VALUES ('standard', 'fallback', 42);
