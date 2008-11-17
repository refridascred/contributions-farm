-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    label TEXT,
    token TEXT,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stream_events_token ON stream_events (token);

INSERT INTO stream_events (label, token, level) VALUES ('legacy', 'staging', 90);
INSERT INTO stream_events (label, token, level) VALUES ('cached', 'local', 57);
INSERT INTO stream_events (label, token, level) VALUES ('cached', 'fallback', 54);
