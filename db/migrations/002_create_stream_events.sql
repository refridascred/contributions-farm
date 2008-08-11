-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    owner TEXT NOT NULL,
    rank INTEGER,
    weight REAL,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stream_events_rank ON stream_events (rank);

INSERT INTO stream_events (count, owner, rank, weight, level) VALUES (70, 'cached', 86, 74.62, 43);
INSERT INTO stream_events (count, owner, rank, weight, level) VALUES (74, 'legacy', 53, 83.92, 23);
