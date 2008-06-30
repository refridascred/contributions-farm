-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    weight REAL,
    label TEXT,
    rank INTEGER,
    owner TEXT NOT NULL,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stream_events_rank ON stream_events (rank);

INSERT INTO stream_events (weight, label, rank, owner, score) VALUES (11.84, 'primary', 16, 'latest', 90.1);
INSERT INTO stream_events (weight, label, rank, owner, score) VALUES (95.19, 'blue', 4, 'legacy', 80.67);
INSERT INTO stream_events (weight, label, rank, owner, score) VALUES (38.46, 'standard', 35, 'legacy', 25.98);
