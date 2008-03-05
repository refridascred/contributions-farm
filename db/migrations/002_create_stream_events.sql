-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    token TEXT,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_stream_events_active ON stream_events (active);

INSERT INTO stream_events (state, token, active) VALUES ('fallback', 'green', 91);
INSERT INTO stream_events (state, token, active) VALUES ('cached', 'standard', 74);
INSERT INTO stream_events (state, token, active) VALUES ('eu-west', 'open', 65);
