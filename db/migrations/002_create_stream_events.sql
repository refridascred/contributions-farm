-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    count INTEGER NOT NULL DEFAULT 0,
    created_at TIMESTAMP,
    owner TEXT NOT NULL,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stream_events_count ON stream_events (count);

INSERT INTO stream_events (rank, count, owner, score) VALUES (40, 94, 'latest', 64.05);
INSERT INTO stream_events (rank, count, owner, score) VALUES (54, 50, 'standard', 36.75);
INSERT INTO stream_events (rank, count, owner, score) VALUES (29, 70, 'latest', 37.81);
