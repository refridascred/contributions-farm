-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    score REAL NOT NULL DEFAULT 0,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stream_events_score ON stream_events (score);

INSERT INTO stream_events (owner, score, rank) VALUES ('edge', 54.23, 15);
INSERT INTO stream_events (owner, score, rank) VALUES ('blue', 4.42, 98);
INSERT INTO stream_events (owner, score, rank) VALUES ('local', 15.64, 72);
