-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    state TEXT NOT NULL DEFAULT 'new',
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stream_events_owner ON stream_events (owner);

INSERT INTO stream_events (owner, state, rank) VALUES ('local', 'latest', 16);
INSERT INTO stream_events (owner, state, rank) VALUES ('blue', 'cached', 48);
INSERT INTO stream_events (owner, state, rank) VALUES ('staging', 'green', 48);
