-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    owner TEXT NOT NULL,
    token TEXT,
    rank INTEGER,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_stream_events_owner ON stream_events (owner);

INSERT INTO stream_events (ratio, owner, token, rank, active) VALUES (97.24, 'standard', 'edge', 59, 33);
INSERT INTO stream_events (ratio, owner, token, rank, active) VALUES (20.08, 'stable', 'legacy', 51, 91);
