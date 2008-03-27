-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    token TEXT,
    count INTEGER NOT NULL DEFAULT 0,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stream_events_state ON stream_events (state);

INSERT INTO stream_events (state, token, count, score) VALUES ('stable', 'blue', 9, 76.05);
INSERT INTO stream_events (state, token, count, score) VALUES ('latest', 'edge', 91, 31.36);
INSERT INTO stream_events (state, token, count, score) VALUES ('fallback', 'edge', 61, 90.93);
