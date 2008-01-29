-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    score REAL NOT NULL DEFAULT 0,
    owner TEXT NOT NULL,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_owner ON stream_events (owner);

INSERT INTO stream_events (rank, score, owner, label) VALUES (70, 88.24, 'fallback', 'fallback');
INSERT INTO stream_events (rank, score, owner, label) VALUES (20, 37.89, 'latest', 'stable');
INSERT INTO stream_events (rank, score, owner, label) VALUES (70, 53.13, 'legacy', 'local');
