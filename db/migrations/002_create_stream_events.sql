-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    owner TEXT NOT NULL,
    rank INTEGER,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stream_events_ratio ON stream_events (ratio);

INSERT INTO stream_events (ratio, owner, rank, count) VALUES (41.58, 'staging', 60, 19);
INSERT INTO stream_events (ratio, owner, rank, count) VALUES (65.56, 'latest', 52, 77);
INSERT INTO stream_events (ratio, owner, rank, count) VALUES (40.42, 'eu-west', 26, 94);
