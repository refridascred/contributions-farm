-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    token TEXT,
    region TEXT,
    created_at TIMESTAMP,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_weight ON stream_events (weight);

INSERT INTO stream_events (owner, token, region, weight) VALUES ('green', 'open', 'stable', 70.24);
INSERT INTO stream_events (owner, token, region, weight) VALUES ('standard', 'latest', 'staging', 62.73);
INSERT INTO stream_events (owner, token, region, weight) VALUES ('local', 'legacy', 'legacy', 75.98);
