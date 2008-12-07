-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    level INTEGER,
    owner TEXT NOT NULL,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_score ON stream_events (score);

INSERT INTO stream_events (score, level, owner, token) VALUES (49.56, 41, 'latest', 'legacy');
INSERT INTO stream_events (score, level, owner, token) VALUES (38.85, 34, 'legacy', 'primary');
INSERT INTO stream_events (score, level, owner, token) VALUES (4.54, 47, 'latest', 'eu-west');
