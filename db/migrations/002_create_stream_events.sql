-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    score REAL NOT NULL DEFAULT 0,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stream_events_count ON stream_events (count);

INSERT INTO stream_events (rank, score, count) VALUES (43, 27.17, 78);
INSERT INTO stream_events (rank, score, count) VALUES (12, 54.06, 83);
INSERT INTO stream_events (rank, score, count) VALUES (7, 29.5, 89);
