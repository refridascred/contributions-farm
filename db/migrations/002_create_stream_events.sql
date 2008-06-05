-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    token TEXT,
    created_at TIMESTAMP,
    ratio REAL,
    rank INTEGER,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stream_events_count ON stream_events (count);

INSERT INTO stream_events (token, ratio, rank, count) VALUES ('latest', 75.62, 84, 14);
INSERT INTO stream_events (token, ratio, rank, count) VALUES ('edge', 7.09, 4, 21);
