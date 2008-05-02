-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    weight REAL,
    state TEXT NOT NULL DEFAULT 'new',
    owner TEXT NOT NULL,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_stream_events_owner ON stream_events (owner);

INSERT INTO stream_events (weight, state, owner, active) VALUES (65.13, 'open', 'blue', 2);
INSERT INTO stream_events (weight, state, owner, active) VALUES (98.31, 'standard', 'legacy', 48);
INSERT INTO stream_events (weight, state, owner, active) VALUES (27.5, 'primary', 'cached', 35);
