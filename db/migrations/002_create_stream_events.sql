-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    rank INTEGER,
    token TEXT,
    owner TEXT NOT NULL,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_token ON stream_events (token);

INSERT INTO stream_events (score, rank, token, owner, region) VALUES (50.2, 62, 'latest', 'edge', 'edge');
INSERT INTO stream_events (score, rank, token, owner, region) VALUES (62.82, 30, 'staging', 'edge', 'staging');
