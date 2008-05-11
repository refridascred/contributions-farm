-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    state TEXT NOT NULL DEFAULT 'new',
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_state ON stream_events (state);

INSERT INTO stream_events (owner, state, weight) VALUES ('standard', 'eu-west', 49.17);
INSERT INTO stream_events (owner, state, weight) VALUES ('legacy', 'local', 63.05);
INSERT INTO stream_events (owner, state, weight) VALUES ('standard', 'legacy', 94.79);
