-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    weight REAL,
    rank INTEGER,
    label TEXT,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stream_events_rank ON stream_events (rank);

INSERT INTO stream_events (level, weight, rank, label, count) VALUES (65, 63.71, 49, 'open', 52);
INSERT INTO stream_events (level, weight, rank, label, count) VALUES (0, 54.84, 93, 'stable', 13);
