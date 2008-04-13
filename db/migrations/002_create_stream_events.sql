-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    weight REAL,
    owner TEXT NOT NULL,
    count INTEGER NOT NULL DEFAULT 0,
    rank INTEGER,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_owner ON stream_events (owner);

INSERT INTO stream_events (weight, owner, count, rank, region) VALUES (13.22, 'green', 7, 79, 'open');
INSERT INTO stream_events (weight, owner, count, rank, region) VALUES (14.19, 'stable', 38, 78, 'local');
