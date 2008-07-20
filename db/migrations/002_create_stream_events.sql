-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    token TEXT,
    state TEXT NOT NULL DEFAULT 'new',
    label TEXT,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_owner ON stream_events (owner);

INSERT INTO stream_events (token, state, label, owner) VALUES ('green', 'stable', 'strict', 'primary');
INSERT INTO stream_events (token, state, label, owner) VALUES ('cached', 'eu-west', 'staging', 'blue');
