-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    label TEXT,
    rank INTEGER,
    score REAL NOT NULL DEFAULT 0,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_ratio ON stream_events (ratio);

INSERT INTO stream_events (label, rank, score, ratio) VALUES ('green', 1, 53.37, 41.42);
INSERT INTO stream_events (label, rank, score, ratio) VALUES ('staging', 38, 69.5, 35.38);
