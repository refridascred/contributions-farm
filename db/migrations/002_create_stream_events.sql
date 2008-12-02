-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    owner TEXT NOT NULL,
    region TEXT,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_stream_events_owner ON stream_events (owner);

INSERT INTO stream_events (owner, region, state) VALUES ('blue', 'legacy', 'standard');
INSERT INTO stream_events (owner, region, state) VALUES ('edge', 'green', 'edge');
INSERT INTO stream_events (owner, region, state) VALUES ('open', 'latest', 'cached');
