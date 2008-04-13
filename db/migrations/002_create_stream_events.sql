-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    weight REAL,
    label TEXT,
    state TEXT NOT NULL DEFAULT 'new',
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_stream_events_active ON stream_events (active);

INSERT INTO stream_events (weight, label, state, active) VALUES (2.29, 'strict', 'strict', 25);
INSERT INTO stream_events (weight, label, state, active) VALUES (40.84, 'local', 'latest', 40);
INSERT INTO stream_events (weight, label, state, active) VALUES (14.61, 'green', 'standard', 62);
