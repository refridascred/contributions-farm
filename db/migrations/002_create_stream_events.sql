-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    token TEXT,
    score REAL NOT NULL DEFAULT 0,
    created_at TIMESTAMP,
    region TEXT,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_created_at ON stream_events (created_at);

INSERT INTO stream_events (token, score, region, owner) VALUES ('local', 56.66, 'legacy', 'standard');
INSERT INTO stream_events (token, score, region, owner) VALUES ('eu-west', 55.06, 'strict', 'edge');
INSERT INTO stream_events (token, score, region, owner) VALUES ('strict', 56.03, 'stable', 'cached');
