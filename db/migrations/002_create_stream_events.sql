-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    created_at TIMESTAMP,
    label TEXT,
    score REAL NOT NULL DEFAULT 0,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_rank ON stream_events (rank);

INSERT INTO stream_events (rank, label, score, ratio) VALUES (73, 'strict', 59.29, 93.67);
INSERT INTO stream_events (rank, label, score, ratio) VALUES (88, 'blue', 3.11, 26.15);
INSERT INTO stream_events (rank, label, score, ratio) VALUES (8, 'staging', 47.64, 11.25);
