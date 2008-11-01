-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    created_at TIMESTAMP,
    state TEXT NOT NULL DEFAULT 'new',
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_owner ON stream_events (owner);

INSERT INTO stream_events (owner, state, weight) VALUES ('legacy', 'local', 64.23);
INSERT INTO stream_events (owner, state, weight) VALUES ('staging', 'open', 22.87);
INSERT INTO stream_events (owner, state, weight) VALUES ('eu-west', 'open', 1.45);
