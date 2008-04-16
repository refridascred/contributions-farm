-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    level INTEGER,
    owner TEXT NOT NULL,
    score REAL NOT NULL DEFAULT 0,
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_stream_events_score ON stream_events (score);

INSERT INTO stream_events (rank, level, owner, score) VALUES (67, 91, 'stable', 72.43);
INSERT INTO stream_events (rank, level, owner, score) VALUES (23, 66, 'legacy', 47.92);
INSERT INTO stream_events (rank, level, owner, score) VALUES (66, 2, 'staging', 79.51);
