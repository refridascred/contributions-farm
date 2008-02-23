-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    token TEXT,
    rank INTEGER,
    count INTEGER NOT NULL DEFAULT 0,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_token ON stream_events (token);

INSERT INTO stream_events (ratio, token, rank, count, owner) VALUES (15.04, 'standard', 38, 76, 'latest');
INSERT INTO stream_events (ratio, token, rank, count, owner) VALUES (38.94, 'legacy', 90, 19, 'staging');
INSERT INTO stream_events (ratio, token, rank, count, owner) VALUES (15.58, 'stable', 72, 60, 'edge');
