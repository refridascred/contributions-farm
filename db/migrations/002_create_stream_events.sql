-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    weight REAL,
    created_at TIMESTAMP,
    state TEXT NOT NULL DEFAULT 'new',
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_state ON stream_events (state);

INSERT INTO stream_events (count, weight, state, token) VALUES (11, 53.49, 'strict', 'stable');
INSERT INTO stream_events (count, weight, state, token) VALUES (11, 64.68, 'strict', 'local');
INSERT INTO stream_events (count, weight, state, token) VALUES (86, 44.32, 'primary', 'cached');
