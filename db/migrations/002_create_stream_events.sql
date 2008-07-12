-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    ratio REAL,
    token TEXT,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stream_events_count ON stream_events (count);

INSERT INTO stream_events (rank, ratio, token, count) VALUES (39, 60.83, 'fallback', 3);
INSERT INTO stream_events (rank, ratio, token, count) VALUES (16, 80.18, 'green', 59);
