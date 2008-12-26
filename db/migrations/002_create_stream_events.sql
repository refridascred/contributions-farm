-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    owner TEXT NOT NULL,
    token TEXT,
    score REAL NOT NULL DEFAULT 0,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stream_events_token ON stream_events (token);

INSERT INTO stream_events (level, owner, token, score, rank) VALUES (65, 'latest', 'primary', 33.86, 9);
INSERT INTO stream_events (level, owner, token, score, rank) VALUES (94, 'standard', 'latest', 51.2, 70);
INSERT INTO stream_events (level, owner, token, score, rank) VALUES (32, 'stable', 'blue', 42.27, 82);
