-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    weight REAL,
    state TEXT NOT NULL DEFAULT 'new',
    count INTEGER NOT NULL DEFAULT 0,
    rank INTEGER,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_token ON stream_events (token);

INSERT INTO stream_events (weight, state, count, rank, token) VALUES (47.06, 'primary', 18, 34, 'open');
INSERT INTO stream_events (weight, state, count, rank, token) VALUES (48.62, 'edge', 81, 17, 'latest');
INSERT INTO stream_events (weight, state, count, rank, token) VALUES (11.75, 'strict', 87, 3, 'open');
