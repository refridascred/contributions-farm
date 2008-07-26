-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    region TEXT,
    label TEXT,
    token TEXT,
    state TEXT NOT NULL DEFAULT 'new',
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_token ON stream_events (token);

INSERT INTO stream_events (region, label, token, state, owner) VALUES ('latest', 'latest', 'eu-west', 'green', 'blue');
INSERT INTO stream_events (region, label, token, state, owner) VALUES ('green', 'edge', 'eu-west', 'open', 'staging');
INSERT INTO stream_events (region, label, token, state, owner) VALUES ('green', 'legacy', 'strict', 'stable', 'strict');
