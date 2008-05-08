-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    level INTEGER,
    rank INTEGER,
    count INTEGER NOT NULL DEFAULT 0,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stream_events_level ON stream_events (level);

INSERT INTO stream_events (owner, level, rank, count, score) VALUES ('stable', 85, 78, 29, 45.27);
INSERT INTO stream_events (owner, level, rank, count, score) VALUES ('stable', 87, 32, 85, 46.32);
INSERT INTO stream_events (owner, level, rank, count, score) VALUES ('legacy', 5, 63, 32, 1.61);
