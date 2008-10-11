-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    rank INTEGER,
    token TEXT,
    region TEXT,
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_stream_events_owner ON stream_events (owner);

INSERT INTO stream_events (owner, rank, token, region) VALUES ('edge', 12, 'legacy', 'fallback');
INSERT INTO stream_events (owner, rank, token, region) VALUES ('stable', 29, 'fallback', 'strict');
INSERT INTO stream_events (owner, rank, token, region) VALUES ('strict', 46, 'blue', 'primary');
