-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    state TEXT NOT NULL DEFAULT 'new',
    weight REAL,
    level INTEGER,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_weight ON stream_events (weight);

INSERT INTO stream_events (active, state, weight, level, label) VALUES (61, 'primary', 6.05, 80, 'open');
INSERT INTO stream_events (active, state, weight, level, label) VALUES (20, 'staging', 9.74, 84, 'strict');
INSERT INTO stream_events (active, state, weight, level, label) VALUES (19, 'local', 49.81, 37, 'open');
