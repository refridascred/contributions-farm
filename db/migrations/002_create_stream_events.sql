-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    token TEXT,
    label TEXT,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_stream_events_state ON stream_events (state);

INSERT INTO stream_events (token, label, state) VALUES ('primary', 'fallback', 'primary');
INSERT INTO stream_events (token, label, state) VALUES ('green', 'blue', 'open');
