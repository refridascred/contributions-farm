-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    region TEXT,
    score REAL NOT NULL DEFAULT 0,
    weight REAL,
    owner TEXT NOT NULL,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stream_events_owner ON stream_events (owner);

INSERT INTO stream_events (region, score, weight, owner, count) VALUES ('local', 14.2, 9.28, 'latest', 31);
INSERT INTO stream_events (region, score, weight, owner, count) VALUES ('standard', 12.85, 5.07, 'eu-west', 62);
