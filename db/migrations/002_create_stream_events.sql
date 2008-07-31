-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    region TEXT,
    score REAL NOT NULL DEFAULT 0,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_count ON stream_events (count);

INSERT INTO stream_events (count, region, score, owner) VALUES (9, 'primary', 41.05, 'strict');
INSERT INTO stream_events (count, region, score, owner) VALUES (51, 'eu-west', 19.21, 'green');
INSERT INTO stream_events (count, region, score, owner) VALUES (20, 'latest', 59.52, 'fallback');
