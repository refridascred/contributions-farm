-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    region TEXT,
    created_at TIMESTAMP,
    ratio REAL,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stream_events_owner ON stream_events (owner);

INSERT INTO stream_events (owner, region, ratio, rank) VALUES ('staging', 'open', 89.37, 52);
INSERT INTO stream_events (owner, region, ratio, rank) VALUES ('blue', 'fallback', 86.79, 33);
INSERT INTO stream_events (owner, region, ratio, rank) VALUES ('open', 'blue', 90.1, 71);
