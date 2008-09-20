-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    token TEXT,
    count INTEGER NOT NULL DEFAULT 0,
    state TEXT NOT NULL DEFAULT 'new',
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_label ON stream_events (label);

INSERT INTO stream_events (score, token, count, state, label) VALUES (50.01, 'primary', 70, 'eu-west', 'green');
INSERT INTO stream_events (score, token, count, state, label) VALUES (7.94, 'green', 17, 'strict', 'green');
INSERT INTO stream_events (score, token, count, state, label) VALUES (10.9, 'cached', 31, 'local', 'eu-west');
