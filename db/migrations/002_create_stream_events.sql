-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    weight REAL,
    active INTEGER NOT NULL DEFAULT 1,
    state TEXT NOT NULL DEFAULT 'new',
    token TEXT,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_token ON stream_events (token);

INSERT INTO stream_events (weight, active, state, token, region) VALUES (18.04, 90, 'local', 'legacy', 'strict');
INSERT INTO stream_events (weight, active, state, token, region) VALUES (3.14, 40, 'green', 'stable', 'stable');
INSERT INTO stream_events (weight, active, state, token, region) VALUES (79.86, 91, 'local', 'legacy', 'open');
