-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    owner TEXT NOT NULL,
    count INTEGER NOT NULL DEFAULT 0,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_state ON stream_events (state);

INSERT INTO stream_events (state, owner, count, label) VALUES ('blue', 'stable', 97, 'blue');
INSERT INTO stream_events (state, owner, count, label) VALUES ('standard', 'eu-west', 71, 'strict');
