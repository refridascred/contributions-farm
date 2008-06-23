-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    label TEXT,
    region TEXT,
    owner TEXT NOT NULL,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stream_events_count ON stream_events (count);

INSERT INTO stream_events (label, region, owner, count) VALUES ('latest', 'green', 'latest', 15);
INSERT INTO stream_events (label, region, owner, count) VALUES ('stable', 'green', 'eu-west', 21);
