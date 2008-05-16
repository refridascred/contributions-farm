-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    weight REAL,
    active INTEGER NOT NULL DEFAULT 1,
    state TEXT NOT NULL DEFAULT 'new',
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_weight ON stream_events (weight);

INSERT INTO stream_events (score, weight, active, state, owner) VALUES (41.72, 41.11, 65, 'edge', 'standard');
INSERT INTO stream_events (score, weight, active, state, owner) VALUES (79.95, 80.87, 77, 'primary', 'latest');
INSERT INTO stream_events (score, weight, active, state, owner) VALUES (75.45, 12.13, 99, 'open', 'strict');
