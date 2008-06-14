-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    token TEXT,
    score REAL NOT NULL DEFAULT 0,
    active INTEGER NOT NULL DEFAULT 1,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_stream_events_state ON stream_events (state);

INSERT INTO stream_events (token, score, active, state) VALUES ('latest', 11.9, 64, 'blue');
INSERT INTO stream_events (token, score, active, state) VALUES ('cached', 83.9, 69, 'eu-west');
INSERT INTO stream_events (token, score, active, state) VALUES ('local', 54.63, 16, 'stable');
