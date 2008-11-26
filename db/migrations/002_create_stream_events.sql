-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    rank INTEGER,
    token TEXT,
    score REAL NOT NULL DEFAULT 0,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_rank ON stream_events (rank);

INSERT INTO stream_events (count, rank, token, score, ratio) VALUES (52, 74, 'blue', 6.88, 94.22);
INSERT INTO stream_events (count, rank, token, score, ratio) VALUES (80, 11, 'eu-west', 46.52, 7.98);
INSERT INTO stream_events (count, rank, token, score, ratio) VALUES (92, 90, 'primary', 11.27, 34.08);
