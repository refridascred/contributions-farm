-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    created_at TIMESTAMP,
    region TEXT,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stream_events_created_at ON stream_events (created_at);

INSERT INTO stream_events (owner, region, score) VALUES ('legacy', 'green', 2.68);
INSERT INTO stream_events (owner, region, score) VALUES ('staging', 'local', 66.52);
INSERT INTO stream_events (owner, region, score) VALUES ('stable', 'staging', 55.94);
