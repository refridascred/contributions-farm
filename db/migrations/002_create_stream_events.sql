-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    level INTEGER,
    owner TEXT NOT NULL,
    rank INTEGER,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_weight ON stream_events (weight);

INSERT INTO stream_events (score, level, owner, rank, weight) VALUES (20.96, 97, 'edge', 39, 69.77);
INSERT INTO stream_events (score, level, owner, rank, weight) VALUES (93.14, 78, 'green', 2, 29.32);
