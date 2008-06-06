-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    level INTEGER,
    score REAL NOT NULL DEFAULT 0,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stream_events_score ON stream_events (score);

INSERT INTO stream_events (owner, level, score, count) VALUES ('cached', 34, 78.1, 19);
INSERT INTO stream_events (owner, level, score, count) VALUES ('local', 28, 50.49, 10);
INSERT INTO stream_events (owner, level, score, count) VALUES ('strict', 60, 37.42, 18);
