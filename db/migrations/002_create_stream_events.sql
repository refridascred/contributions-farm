-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    token TEXT,
    label TEXT,
    state TEXT NOT NULL DEFAULT 'new',
    owner TEXT NOT NULL,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stream_events_state ON stream_events (state);

INSERT INTO stream_events (token, label, state, owner, rank) VALUES ('blue', 'eu-west', 'cached', 'edge', 65);
INSERT INTO stream_events (token, label, state, owner, rank) VALUES ('open', 'open', 'open', 'latest', 57);
INSERT INTO stream_events (token, label, state, owner, rank) VALUES ('strict', 'fallback', 'local', 'cached', 71);
