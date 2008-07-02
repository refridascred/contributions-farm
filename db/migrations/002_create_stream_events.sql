-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    created_at TIMESTAMP,
    score REAL NOT NULL DEFAULT 0,
    token TEXT,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stream_events_ratio ON stream_events (ratio);

INSERT INTO stream_events (ratio, score, token, rank) VALUES (95.64, 34.59, 'blue', 90);
INSERT INTO stream_events (ratio, score, token, rank) VALUES (89.82, 22.73, 'primary', 23);
INSERT INTO stream_events (ratio, score, token, rank) VALUES (23.84, 11.12, 'latest', 30);
