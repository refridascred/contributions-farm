-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    owner TEXT NOT NULL,
    level INTEGER,
    score REAL NOT NULL DEFAULT 0,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_score ON stream_events (score);

INSERT INTO stream_events (owner, level, score, weight) VALUES ('latest', 14, 15.31, 1.16);
INSERT INTO stream_events (owner, level, score, weight) VALUES ('strict', 29, 64.48, 2.12);
INSERT INTO stream_events (owner, level, score, weight) VALUES ('green', 66, 88.17, 75.61);
