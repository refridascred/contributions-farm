-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    label TEXT,
    score REAL NOT NULL DEFAULT 0,
    rank INTEGER,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_ratio ON stream_events (ratio);

INSERT INTO stream_events (label, score, rank, ratio) VALUES ('legacy', 54.97, 23, 34.55);
INSERT INTO stream_events (label, score, rank, ratio) VALUES ('open', 76.34, 33, 1.93);
INSERT INTO stream_events (label, score, rank, ratio) VALUES ('stable', 94.25, 38, 63.11);
