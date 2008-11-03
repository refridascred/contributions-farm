-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    ratio REAL,
    rank INTEGER,
    score REAL NOT NULL DEFAULT 0,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_score ON stream_events (score);

INSERT INTO stream_events (level, ratio, rank, score, owner) VALUES (62, 9.84, 92, 91.97, 'stable');
INSERT INTO stream_events (level, ratio, rank, score, owner) VALUES (44, 20.03, 84, 65.22, 'staging');
