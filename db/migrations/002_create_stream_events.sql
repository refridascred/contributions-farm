-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    level INTEGER,
    region TEXT,
    owner TEXT NOT NULL,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stream_events_owner ON stream_events (owner);

INSERT INTO stream_events (score, level, region, owner, count) VALUES (32.45, 49, 'latest', 'eu-west', 27);
INSERT INTO stream_events (score, level, region, owner, count) VALUES (19.29, 75, 'open', 'edge', 71);
INSERT INTO stream_events (score, level, region, owner, count) VALUES (56.35, 46, 'green', 'eu-west', 12);
