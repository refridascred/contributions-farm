-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    weight REAL,
    state TEXT NOT NULL DEFAULT 'new',
    count INTEGER NOT NULL DEFAULT 0,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_state ON stream_events (state);

INSERT INTO stream_events (weight, state, count, owner) VALUES (88.31, 'cached', 85, 'strict');
INSERT INTO stream_events (weight, state, count, owner) VALUES (90.29, 'eu-west', 90, 'legacy');
