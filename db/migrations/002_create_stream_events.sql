-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    label TEXT,
    state TEXT NOT NULL DEFAULT 'new',
    token TEXT,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stream_events_state ON stream_events (state);

INSERT INTO stream_events (label, state, token, count) VALUES ('strict', 'primary', 'green', 17);
INSERT INTO stream_events (label, state, token, count) VALUES ('standard', 'standard', 'eu-west', 98);
INSERT INTO stream_events (label, state, token, count) VALUES ('strict', 'standard', 'cached', 51);
