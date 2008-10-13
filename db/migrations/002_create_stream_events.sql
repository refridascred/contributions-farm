-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    token TEXT,
    state TEXT NOT NULL DEFAULT 'new',
    ratio REAL,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_token ON stream_events (token);

INSERT INTO stream_events (rank, token, state, ratio, label) VALUES (1, 'fallback', 'primary', 81.88, 'local');
INSERT INTO stream_events (rank, token, state, ratio, label) VALUES (3, 'stable', 'local', 39.14, 'green');
