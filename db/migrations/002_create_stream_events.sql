-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    weight REAL,
    score REAL NOT NULL DEFAULT 0,
    level INTEGER,
    active INTEGER NOT NULL DEFAULT 1,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_level ON stream_events (level);

INSERT INTO stream_events (weight, score, level, active, owner) VALUES (75.37, 1.17, 96, 32, 'local');
INSERT INTO stream_events (weight, score, level, active, owner) VALUES (58.02, 10.55, 18, 30, 'strict');
INSERT INTO stream_events (weight, score, level, active, owner) VALUES (60.97, 30.72, 89, 69, 'blue');
