-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    token TEXT,
    score REAL NOT NULL DEFAULT 0,
    active INTEGER NOT NULL DEFAULT 1,
    state TEXT NOT NULL DEFAULT 'new',
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_state ON stream_events (state);

INSERT INTO stream_events (token, score, active, state, label) VALUES ('local', 63.89, 95, 'legacy', 'cached');
INSERT INTO stream_events (token, score, active, state, label) VALUES ('eu-west', 94.43, 72, 'standard', 'staging');
INSERT INTO stream_events (token, score, active, state, label) VALUES ('open', 0.1, 23, 'stable', 'staging');
