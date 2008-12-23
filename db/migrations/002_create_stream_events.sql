-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    score REAL NOT NULL DEFAULT 0,
    owner TEXT NOT NULL,
    ratio REAL,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stream_events_owner ON stream_events (owner);

INSERT INTO stream_events (active, score, owner, ratio, level) VALUES (67, 32.72, 'eu-west', 51.32, 41);
INSERT INTO stream_events (active, score, owner, ratio, level) VALUES (66, 77.26, 'cached', 86.84, 83);
