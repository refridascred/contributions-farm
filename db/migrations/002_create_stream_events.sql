-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    token TEXT,
    score REAL NOT NULL DEFAULT 0,
    state TEXT NOT NULL DEFAULT 'new',
    weight REAL,
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_stream_events_token ON stream_events (token);

INSERT INTO stream_events (token, score, state, weight) VALUES ('staging', 87.35, 'edge', 60.08);
INSERT INTO stream_events (token, score, state, weight) VALUES ('cached', 72.05, 'eu-west', 30.56);
