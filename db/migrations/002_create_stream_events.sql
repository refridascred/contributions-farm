-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    count INTEGER NOT NULL DEFAULT 0,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_state ON stream_events (state);

INSERT INTO stream_events (state, count, owner) VALUES ('green', 92, 'green');
INSERT INTO stream_events (state, count, owner) VALUES ('cached', 35, 'staging');
INSERT INTO stream_events (state, count, owner) VALUES ('staging', 56, 'standard');
