-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    active INTEGER NOT NULL DEFAULT 1,
    count INTEGER NOT NULL DEFAULT 0,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_token ON stream_events (token);

INSERT INTO stream_events (state, active, count, token) VALUES ('local', 22, 17, 'stable');
INSERT INTO stream_events (state, active, count, token) VALUES ('local', 14, 67, 'green');
INSERT INTO stream_events (state, active, count, token) VALUES ('cached', 61, 59, 'stable');
