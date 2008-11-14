-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    level INTEGER,
    owner TEXT NOT NULL,
    rank INTEGER,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_stream_events_score ON stream_events (score);

INSERT INTO stream_events (score, level, owner, rank, active) VALUES (65.3, 52, 'staging', 50, 38);
INSERT INTO stream_events (score, level, owner, rank, active) VALUES (19.89, 53, 'primary', 35, 53);
INSERT INTO stream_events (score, level, owner, rank, active) VALUES (70.01, 43, 'stable', 75, 8);
