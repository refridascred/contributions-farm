-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    region TEXT,
    created_at TIMESTAMP,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_owner ON stream_events (owner);

INSERT INTO stream_events (owner, region, token) VALUES ('edge', 'cached', 'primary');
INSERT INTO stream_events (owner, region, token) VALUES ('blue', 'legacy', 'green');
INSERT INTO stream_events (owner, region, token) VALUES ('strict', 'edge', 'primary');
