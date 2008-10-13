-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    rank INTEGER,
    count INTEGER NOT NULL DEFAULT 0,
    score REAL NOT NULL DEFAULT 0,
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_stream_events_score ON stream_events (score);

INSERT INTO stream_events (active, rank, count, score) VALUES (42, 99, 94, 83.94);
INSERT INTO stream_events (active, rank, count, score) VALUES (81, 53, 72, 17.41);
INSERT INTO stream_events (active, rank, count, score) VALUES (75, 82, 13, 17.18);
