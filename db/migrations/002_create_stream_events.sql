-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    created_at TIMESTAMP,
    count INTEGER NOT NULL DEFAULT 0,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_count ON stream_events (count);

INSERT INTO stream_events (owner, count, region) VALUES ('green', 30, 'latest');
INSERT INTO stream_events (owner, count, region) VALUES ('staging', 17, 'cached');
INSERT INTO stream_events (owner, count, region) VALUES ('latest', 50, 'eu-west');
