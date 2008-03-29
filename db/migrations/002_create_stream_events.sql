-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    state TEXT NOT NULL DEFAULT 'new',
    score REAL NOT NULL DEFAULT 0,
    token TEXT,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_token ON stream_events (token);

INSERT INTO stream_events (active, state, score, token, label) VALUES (43, 'standard', 54.17, 'primary', 'stable');
INSERT INTO stream_events (active, state, score, token, label) VALUES (44, 'blue', 14.54, 'eu-west', 'latest');
INSERT INTO stream_events (active, state, score, token, label) VALUES (69, 'staging', 20.89, 'green', 'primary');
