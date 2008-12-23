-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    state TEXT NOT NULL DEFAULT 'new',
    ratio REAL,
    token TEXT,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stream_events_state ON stream_events (state);

INSERT INTO stream_events (count, state, ratio, token, score) VALUES (64, 'green', 6.17, 'staging', 17.66);
INSERT INTO stream_events (count, state, ratio, token, score) VALUES (30, 'strict', 4.1, 'open', 62.86);
INSERT INTO stream_events (count, state, ratio, token, score) VALUES (58, 'local', 29.62, 'latest', 24.53);
