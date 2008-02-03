-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    token TEXT,
    region TEXT,
    count INTEGER NOT NULL DEFAULT 0,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stream_events_region ON stream_events (region);

INSERT INTO stream_events (token, region, count, score) VALUES ('staging', 'primary', 21, 84.8);
INSERT INTO stream_events (token, region, count, score) VALUES ('eu-west', 'latest', 97, 82.58);
