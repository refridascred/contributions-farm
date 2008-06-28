-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    owner TEXT NOT NULL,
    score REAL NOT NULL DEFAULT 0,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stream_events_score ON stream_events (score);

INSERT INTO stream_events (owner, score, count) VALUES ('legacy', 72.2, 36);
INSERT INTO stream_events (owner, score, count) VALUES ('latest', 78.32, 54);
INSERT INTO stream_events (owner, score, count) VALUES ('latest', 28.21, 41);
