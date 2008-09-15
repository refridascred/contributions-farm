-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    token TEXT,
    state TEXT NOT NULL DEFAULT 'new',
    owner TEXT NOT NULL,
    created_at TIMESTAMP,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_stream_events_created_at ON stream_events (created_at);

INSERT INTO stream_events (token, state, owner, active) VALUES ('cached', 'green', 'blue', 25);
INSERT INTO stream_events (token, state, owner, active) VALUES ('stable', 'local', 'green', 37);
INSERT INTO stream_events (token, state, owner, active) VALUES ('open', 'local', 'local', 31);
