-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    label TEXT,
    owner TEXT NOT NULL,
    region TEXT,
    created_at TIMESTAMP,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stream_events_created_at ON stream_events (created_at);

INSERT INTO stream_events (label, owner, region, score) VALUES ('fallback', 'open', 'blue', 14.19);
INSERT INTO stream_events (label, owner, region, score) VALUES ('primary', 'blue', 'open', 3.53);
INSERT INTO stream_events (label, owner, region, score) VALUES ('blue', 'open', 'local', 15.05);
