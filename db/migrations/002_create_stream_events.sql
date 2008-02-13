-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    rank INTEGER,
    created_at TIMESTAMP,
    count INTEGER NOT NULL DEFAULT 0,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stream_events_count ON stream_events (count);

INSERT INTO stream_events (owner, rank, count, score) VALUES ('strict', 12, 35, 63.36);
INSERT INTO stream_events (owner, rank, count, score) VALUES ('primary', 79, 10, 84.06);
