-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    region TEXT,
    ratio REAL,
    rank INTEGER,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stream_events_score ON stream_events (score);

INSERT INTO stream_events (active, region, ratio, rank, score) VALUES (19, 'local', 7.62, 33, 3.48);
INSERT INTO stream_events (active, region, ratio, rank, score) VALUES (61, 'green', 39.59, 55, 40.03);
INSERT INTO stream_events (active, region, ratio, rank, score) VALUES (37, 'open', 64.72, 79, 27.82);
