-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    ratio REAL,
    count INTEGER NOT NULL DEFAULT 0,
    token TEXT,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stream_events_count ON stream_events (count);

INSERT INTO stream_events (score, ratio, count, token, rank) VALUES (94.3, 36.91, 15, 'blue', 31);
INSERT INTO stream_events (score, ratio, count, token, rank) VALUES (31.62, 78.24, 57, 'staging', 73);
