-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    region TEXT,
    ratio REAL,
    rank INTEGER,
    count INTEGER NOT NULL DEFAULT 0,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stream_events_ratio ON stream_events (ratio);

INSERT INTO stream_events (region, ratio, rank, count, score) VALUES ('cached', 60.61, 13, 57, 49.47);
INSERT INTO stream_events (region, ratio, rank, count, score) VALUES ('edge', 60.91, 89, 73, 33.62);
