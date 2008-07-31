-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    owner TEXT NOT NULL,
    weight REAL,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stream_events_score ON stream_events (score);

INSERT INTO stream_events (level, owner, weight, score) VALUES (11, 'legacy', 95.22, 36.58);
INSERT INTO stream_events (level, owner, weight, score) VALUES (90, 'local', 78.33, 81.56);
