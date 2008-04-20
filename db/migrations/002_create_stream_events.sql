-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    label TEXT,
    active INTEGER NOT NULL DEFAULT 1,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_stream_events_state ON stream_events (state);

INSERT INTO stream_events (label, active, state) VALUES ('open', 59, 'blue');
INSERT INTO stream_events (label, active, state) VALUES ('stable', 37, 'strict');
INSERT INTO stream_events (label, active, state) VALUES ('local', 61, 'fallback');
