-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    weight REAL,
    active INTEGER NOT NULL DEFAULT 1,
    state TEXT NOT NULL DEFAULT 'new',
    label TEXT,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stream_events_state ON stream_events (state);

INSERT INTO stream_events (weight, active, state, label, score) VALUES (39.35, 52, 'staging', 'standard', 18.17);
INSERT INTO stream_events (weight, active, state, label, score) VALUES (78.74, 34, 'edge', 'green', 67.75);
INSERT INTO stream_events (weight, active, state, label, score) VALUES (30.33, 42, 'blue', 'primary', 68.34);
