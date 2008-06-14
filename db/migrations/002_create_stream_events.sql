-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    token TEXT,
    count INTEGER NOT NULL DEFAULT 0,
    weight REAL,
    rank INTEGER,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_rank ON stream_events (rank);

INSERT INTO stream_events (token, count, weight, rank, owner) VALUES ('fallback', 58, 54.38, 10, 'eu-west');
INSERT INTO stream_events (token, count, weight, rank, owner) VALUES ('primary', 85, 14.72, 56, 'local');
INSERT INTO stream_events (token, count, weight, rank, owner) VALUES ('fallback', 74, 69.05, 16, 'green');
