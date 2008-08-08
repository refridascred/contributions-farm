-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    token TEXT,
    label TEXT,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_stream_events_token ON stream_events (token);

INSERT INTO stream_events (state, token, label, active) VALUES ('open', 'local', 'legacy', 10);
INSERT INTO stream_events (state, token, label, active) VALUES ('strict', 'fallback', 'local', 83);
INSERT INTO stream_events (state, token, label, active) VALUES ('legacy', 'local', 'eu-west', 92);
