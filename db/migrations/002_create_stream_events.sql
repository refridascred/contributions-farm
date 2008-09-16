-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    weight REAL,
    active INTEGER NOT NULL DEFAULT 1,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_state ON stream_events (state);

INSERT INTO stream_events (state, weight, active, owner) VALUES ('local', 68.88, 25, 'latest');
INSERT INTO stream_events (state, weight, active, owner) VALUES ('primary', 85.44, 57, 'edge');
INSERT INTO stream_events (state, weight, active, owner) VALUES ('green', 61.0, 89, 'cached');
