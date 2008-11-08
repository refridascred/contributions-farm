-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    region TEXT,
    label TEXT,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stream_events_rank ON stream_events (rank);

INSERT INTO stream_events (rank, region, label, score) VALUES (35, 'green', 'cached', 29.97);
INSERT INTO stream_events (rank, region, label, score) VALUES (6, 'stable', 'stable', 95.23);
INSERT INTO stream_events (rank, region, label, score) VALUES (90, 'green', 'primary', 83.88);
