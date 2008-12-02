-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    token TEXT,
    rank INTEGER,
    score REAL NOT NULL DEFAULT 0,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_score ON stream_events (score);

INSERT INTO stream_events (token, rank, score, ratio) VALUES ('blue', 20, 52.93, 60.69);
INSERT INTO stream_events (token, rank, score, ratio) VALUES ('strict', 47, 8.95, 58.11);
INSERT INTO stream_events (token, rank, score, ratio) VALUES ('edge', 84, 83.94, 98.71);
