-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    rank INTEGER,
    score REAL NOT NULL DEFAULT 0,
    level INTEGER,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_score ON stream_events (score);

INSERT INTO stream_events (active, rank, score, level, token) VALUES (44, 27, 66.15, 23, 'latest');
INSERT INTO stream_events (active, rank, score, level, token) VALUES (90, 44, 81.75, 65, 'eu-west');
INSERT INTO stream_events (active, rank, score, level, token) VALUES (42, 92, 31.17, 76, 'green');
