-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    score REAL NOT NULL DEFAULT 0,
    rank INTEGER,
    level INTEGER,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_score ON stream_events (score);

INSERT INTO stream_events (owner, score, rank, level, ratio) VALUES ('local', 28.68, 98, 87, 89.15);
INSERT INTO stream_events (owner, score, rank, level, ratio) VALUES ('latest', 87.92, 44, 12, 63.51);
INSERT INTO stream_events (owner, score, rank, level, ratio) VALUES ('stable', 48.11, 23, 93, 53.03);
