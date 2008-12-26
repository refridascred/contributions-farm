-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    ratio REAL,
    created_at TIMESTAMP,
    active INTEGER NOT NULL DEFAULT 1,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stream_events_rank ON stream_events (rank);

INSERT INTO stream_events (rank, ratio, active, score) VALUES (0, 81.69, 10, 65.81);
INSERT INTO stream_events (rank, ratio, active, score) VALUES (75, 7.25, 25, 1.09);
INSERT INTO stream_events (rank, ratio, active, score) VALUES (38, 85.2, 13, 90.14);
