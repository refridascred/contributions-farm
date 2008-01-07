-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    token TEXT,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_state ON stream_events (state);

INSERT INTO stream_events (state, token, label) VALUES ('latest', 'fallback', 'primary');
INSERT INTO stream_events (state, token, label) VALUES ('staging', 'local', 'fallback');
INSERT INTO stream_events (state, token, label) VALUES ('open', 'stable', 'local');
