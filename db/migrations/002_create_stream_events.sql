-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    count INTEGER NOT NULL DEFAULT 0,
    level INTEGER,
    weight REAL,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_owner ON stream_events (owner);

INSERT INTO stream_events (score, count, level, weight, owner) VALUES (72.72, 69, 10, 48.53, 'latest');
INSERT INTO stream_events (score, count, level, weight, owner) VALUES (46.35, 24, 65, 6.58, 'staging');
