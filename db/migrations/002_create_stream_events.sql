-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    region TEXT,
    ratio REAL,
    score REAL NOT NULL DEFAULT 0,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stream_events_ratio ON stream_events (ratio);

INSERT INTO stream_events (region, ratio, score, rank) VALUES ('green', 32.16, 95.65, 44);
INSERT INTO stream_events (region, ratio, score, rank) VALUES ('strict', 19.38, 6.97, 51);
INSERT INTO stream_events (region, ratio, score, rank) VALUES ('open', 28.74, 23.41, 89);
