-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    region TEXT,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_score ON stream_events (score);

INSERT INTO stream_events (score, region, owner) VALUES (54.98, 'edge', 'edge');
INSERT INTO stream_events (score, region, owner) VALUES (7.71, 'cached', 'latest');
INSERT INTO stream_events (score, region, owner) VALUES (89.13, 'strict', 'open');
