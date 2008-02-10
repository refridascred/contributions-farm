-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    token TEXT,
    rank INTEGER,
    ratio REAL,
    owner TEXT NOT NULL,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_ratio ON stream_events (ratio);

INSERT INTO stream_events (token, rank, ratio, owner, region) VALUES ('green', 95, 53.1, 'fallback', 'latest');
INSERT INTO stream_events (token, rank, ratio, owner, region) VALUES ('staging', 89, 92.36, 'latest', 'strict');
