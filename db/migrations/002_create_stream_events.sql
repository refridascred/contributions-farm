-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    region TEXT,
    count INTEGER NOT NULL DEFAULT 0,
    token TEXT,
    score REAL NOT NULL DEFAULT 0,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_score ON stream_events (score);

INSERT INTO stream_events (region, count, token, score, ratio) VALUES ('latest', 88, 'blue', 50.34, 2.7);
INSERT INTO stream_events (region, count, token, score, ratio) VALUES ('local', 4, 'legacy', 94.39, 18.97);
INSERT INTO stream_events (region, count, token, score, ratio) VALUES ('strict', 1, 'local', 37.28, 13.15);
