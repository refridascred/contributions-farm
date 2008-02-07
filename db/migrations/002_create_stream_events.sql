-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    region TEXT,
    level INTEGER,
    score REAL NOT NULL DEFAULT 0,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stream_events_rank ON stream_events (rank);

INSERT INTO stream_events (count, region, level, score, rank) VALUES (93, 'eu-west', 22, 54.25, 5);
INSERT INTO stream_events (count, region, level, score, rank) VALUES (55, 'eu-west', 65, 69.51, 3);
