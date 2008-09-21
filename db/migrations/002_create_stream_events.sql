-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    weight REAL,
    state TEXT NOT NULL DEFAULT 'new',
    level INTEGER,
    token TEXT,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_state ON stream_events (state);

INSERT INTO stream_events (weight, state, level, token, owner) VALUES (73.88, 'cached', 6, 'legacy', 'legacy');
INSERT INTO stream_events (weight, state, level, token, owner) VALUES (55.6, 'local', 70, 'blue', 'eu-west');
