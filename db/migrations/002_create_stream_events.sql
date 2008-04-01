-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    count INTEGER NOT NULL DEFAULT 0,
    region TEXT,
    label TEXT,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stream_events_rank ON stream_events (rank);

INSERT INTO stream_events (owner, count, region, label, rank) VALUES ('legacy', 21, 'stable', 'primary', 50);
INSERT INTO stream_events (owner, count, region, label, rank) VALUES ('fallback', 32, 'stable', 'blue', 3);
INSERT INTO stream_events (owner, count, region, label, rank) VALUES ('strict', 53, 'standard', 'eu-west', 31);
