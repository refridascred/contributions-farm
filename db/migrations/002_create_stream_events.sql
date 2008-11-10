-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    state TEXT NOT NULL DEFAULT 'new',
    created_at TIMESTAMP,
    token TEXT,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_owner ON stream_events (owner);

INSERT INTO stream_events (owner, state, token, weight) VALUES ('fallback', 'standard', 'green', 60.71);
INSERT INTO stream_events (owner, state, token, weight) VALUES ('local', 'strict', 'blue', 51.76);
