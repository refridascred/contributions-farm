-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    region TEXT,
    ratio REAL,
    rank INTEGER,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stream_events_rank ON stream_events (rank);

INSERT INTO stream_events (owner, region, ratio, rank, score) VALUES ('eu-west', 'cached', 9.47, 37, 23.49);
INSERT INTO stream_events (owner, region, ratio, rank, score) VALUES ('primary', 'open', 62.35, 23, 10.43);
INSERT INTO stream_events (owner, region, ratio, rank, score) VALUES ('fallback', 'blue', 76.49, 49, 91.78);
