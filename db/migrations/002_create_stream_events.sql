-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    created_at TIMESTAMP,
    state TEXT NOT NULL DEFAULT 'new',
    token TEXT,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stream_events_owner ON stream_events (owner);

INSERT INTO stream_events (owner, state, token, rank) VALUES ('eu-west', 'staging', 'open', 60);
INSERT INTO stream_events (owner, state, token, rank) VALUES ('blue', 'local', 'stable', 49);
INSERT INTO stream_events (owner, state, token, rank) VALUES ('primary', 'open', 'stable', 49);
