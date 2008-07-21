-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    created_at TIMESTAMP,
    owner TEXT NOT NULL,
    rank INTEGER,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_score ON stream_events (score);

INSERT INTO stream_events (score, owner, rank, weight) VALUES (52.62, 'stable', 84, 84.52);
INSERT INTO stream_events (score, owner, rank, weight) VALUES (73.28, 'staging', 96, 76.02);
INSERT INTO stream_events (score, owner, rank, weight) VALUES (79.44, 'strict', 44, 7.31);
