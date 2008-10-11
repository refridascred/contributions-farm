-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    token TEXT,
    state TEXT NOT NULL DEFAULT 'new',
    score REAL NOT NULL DEFAULT 0,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_token ON stream_events (token);

INSERT INTO stream_events (token, state, score, ratio) VALUES ('legacy', 'staging', 67.86, 95.93);
INSERT INTO stream_events (token, state, score, ratio) VALUES ('legacy', 'green', 14.38, 55.74);
