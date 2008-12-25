-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    region TEXT,
    label TEXT,
    owner TEXT NOT NULL,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stream_events_count ON stream_events (count);

INSERT INTO stream_events (rank, region, label, owner, count) VALUES (54, 'local', 'fallback', 'legacy', 91);
INSERT INTO stream_events (rank, region, label, owner, count) VALUES (33, 'eu-west', 'open', 'fallback', 37);
INSERT INTO stream_events (rank, region, label, owner, count) VALUES (2, 'local', 'open', 'staging', 52);
