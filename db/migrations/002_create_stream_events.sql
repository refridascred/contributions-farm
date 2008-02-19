-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    token TEXT,
    state TEXT NOT NULL DEFAULT 'new',
    weight REAL,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_owner ON stream_events (owner);

INSERT INTO stream_events (token, state, weight, owner) VALUES ('edge', 'local', 38.7, 'primary');
INSERT INTO stream_events (token, state, weight, owner) VALUES ('legacy', 'green', 15.98, 'edge');
