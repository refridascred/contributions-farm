-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    region TEXT,
    owner TEXT NOT NULL,
    ratio REAL,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stream_events_owner ON stream_events (owner);

INSERT INTO stream_events (region, owner, ratio, score) VALUES ('eu-west', 'edge', 13.65, 34.87);
INSERT INTO stream_events (region, owner, ratio, score) VALUES ('eu-west', 'latest', 45.59, 32.1);
