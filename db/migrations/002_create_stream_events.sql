-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    rank INTEGER,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_owner ON stream_events (owner);

INSERT INTO stream_events (state, rank, owner) VALUES ('staging', 91, 'eu-west');
INSERT INTO stream_events (state, rank, owner) VALUES ('edge', 37, 'legacy');
INSERT INTO stream_events (state, rank, owner) VALUES ('primary', 92, 'standard');
