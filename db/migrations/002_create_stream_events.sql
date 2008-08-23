-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    owner TEXT NOT NULL,
    rank INTEGER,
    weight REAL,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stream_events_score ON stream_events (score);

INSERT INTO stream_events (owner, rank, weight, score) VALUES ('latest', 69, 40.09, 37.4);
INSERT INTO stream_events (owner, rank, weight, score) VALUES ('legacy', 66, 92.68, 22.47);
