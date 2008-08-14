-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    token TEXT,
    rank INTEGER,
    active INTEGER NOT NULL DEFAULT 1,
    state TEXT NOT NULL DEFAULT 'new',
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stream_events_active ON stream_events (active);

INSERT INTO stream_events (token, rank, active, state, score) VALUES ('primary', 20, 5, 'latest', 84.62);
INSERT INTO stream_events (token, rank, active, state, score) VALUES ('staging', 92, 88, 'local', 37.91);
INSERT INTO stream_events (token, rank, active, state, score) VALUES ('eu-west', 22, 86, 'primary', 90.77);
