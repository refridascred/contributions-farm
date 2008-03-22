-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    label TEXT,
    owner TEXT NOT NULL,
    count INTEGER NOT NULL DEFAULT 0,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stream_events_owner ON stream_events (owner);

INSERT INTO stream_events (rank, label, owner, count, score) VALUES (61, 'legacy', 'primary', 10, 85.72);
INSERT INTO stream_events (rank, label, owner, count, score) VALUES (76, 'standard', 'latest', 99, 65.26);
INSERT INTO stream_events (rank, label, owner, count, score) VALUES (29, 'stable', 'legacy', 67, 86.17);
