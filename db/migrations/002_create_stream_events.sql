-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    score REAL NOT NULL DEFAULT 0,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_score ON stream_events (score);

INSERT INTO stream_events (state, score, label) VALUES ('cached', 42.14, 'blue');
INSERT INTO stream_events (state, score, label) VALUES ('edge', 28.98, 'strict');
INSERT INTO stream_events (state, score, label) VALUES ('latest', 53.99, 'open');
