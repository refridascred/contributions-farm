-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    token TEXT,
    owner TEXT NOT NULL,
    score REAL NOT NULL DEFAULT 0,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_token ON stream_events (token);

INSERT INTO stream_events (rank, token, owner, score, weight) VALUES (13, 'green', 'primary', 4.58, 72.5);
INSERT INTO stream_events (rank, token, owner, score, weight) VALUES (23, 'stable', 'open', 41.82, 86.46);
