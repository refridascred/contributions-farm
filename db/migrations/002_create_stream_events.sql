-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    score REAL NOT NULL DEFAULT 0,
    ratio REAL,
    token TEXT,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_stream_events_ratio ON stream_events (ratio);

INSERT INTO stream_events (rank, score, ratio, token, active) VALUES (34, 82.65, 22.5, 'green', 30);
INSERT INTO stream_events (rank, score, ratio, token, active) VALUES (48, 73.89, 88.7, 'eu-west', 63);
