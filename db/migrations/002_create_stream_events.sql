-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    owner TEXT NOT NULL,
    level INTEGER,
    weight REAL,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stream_events_score ON stream_events (score);

INSERT INTO stream_events (score, owner, level, weight, count) VALUES (44.46, 'cached', 81, 1.94, 75);
INSERT INTO stream_events (score, owner, level, weight, count) VALUES (10.94, 'latest', 9, 38.94, 81);
INSERT INTO stream_events (score, owner, level, weight, count) VALUES (63.61, 'green', 19, 27.4, 86);
