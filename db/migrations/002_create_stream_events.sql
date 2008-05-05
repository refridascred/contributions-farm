-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    token TEXT,
    state TEXT NOT NULL DEFAULT 'new',
    active INTEGER NOT NULL DEFAULT 1,
    rank INTEGER,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stream_events_active ON stream_events (active);

INSERT INTO stream_events (token, state, active, rank, score) VALUES ('staging', 'primary', 32, 82, 69.36);
INSERT INTO stream_events (token, state, active, rank, score) VALUES ('legacy', 'stable', 57, 63, 91.85);
