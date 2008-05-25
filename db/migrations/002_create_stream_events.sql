-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    score REAL NOT NULL DEFAULT 0,
    active INTEGER NOT NULL DEFAULT 1,
    token TEXT,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stream_events_rank ON stream_events (rank);

INSERT INTO stream_events (owner, score, active, token, rank) VALUES ('fallback', 41.96, 89, 'standard', 3);
INSERT INTO stream_events (owner, score, active, token, rank) VALUES ('eu-west', 84.77, 99, 'primary', 33);
INSERT INTO stream_events (owner, score, active, token, rank) VALUES ('staging', 9.02, 91, 'latest', 22);
