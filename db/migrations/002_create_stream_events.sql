-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    state TEXT NOT NULL DEFAULT 'new',
    label TEXT,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_state ON stream_events (state);

INSERT INTO stream_events (count, state, label, weight) VALUES (93, 'blue', 'stable', 35.64);
INSERT INTO stream_events (count, state, label, weight) VALUES (14, 'local', 'green', 83.82);
INSERT INTO stream_events (count, state, label, weight) VALUES (78, 'stable', 'green', 13.36);
