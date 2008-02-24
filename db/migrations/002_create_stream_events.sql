-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    label TEXT,
    state TEXT NOT NULL DEFAULT 'new',
    token TEXT,
    ratio REAL,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stream_events_state ON stream_events (state);

INSERT INTO stream_events (label, state, token, ratio, score) VALUES ('fallback', 'fallback', 'blue', 86.11, 31.37);
INSERT INTO stream_events (label, state, token, ratio, score) VALUES ('green', 'open', 'legacy', 56.95, 95.17);
INSERT INTO stream_events (label, state, token, ratio, score) VALUES ('stable', 'primary', 'eu-west', 65.02, 54.36);
