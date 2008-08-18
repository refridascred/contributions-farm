-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    label TEXT,
    count INTEGER NOT NULL DEFAULT 0,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stream_events_count ON stream_events (count);

INSERT INTO stream_events (score, label, count, rank) VALUES (59.08, 'legacy', 37, 3);
INSERT INTO stream_events (score, label, count, rank) VALUES (75.56, 'stable', 23, 74);
INSERT INTO stream_events (score, label, count, rank) VALUES (74.46, 'blue', 72, 40);
