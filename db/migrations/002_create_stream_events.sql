-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    created_at TIMESTAMP,
    rank INTEGER,
    score REAL NOT NULL DEFAULT 0,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_created_at ON stream_events (created_at);

INSERT INTO stream_events (ratio, rank, score, token) VALUES (88.93, 40, 57.8, 'strict');
INSERT INTO stream_events (ratio, rank, score, token) VALUES (23.86, 24, 4.25, 'latest');
INSERT INTO stream_events (ratio, rank, score, token) VALUES (34.35, 54, 58.72, 'green');
