-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    active INTEGER NOT NULL DEFAULT 1,
    rank INTEGER,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_rank ON stream_events (rank);

INSERT INTO stream_events (count, active, rank, region) VALUES (22, 29, 25, 'stable');
INSERT INTO stream_events (count, active, rank, region) VALUES (13, 50, 27, 'latest');
INSERT INTO stream_events (count, active, rank, region) VALUES (11, 4, 78, 'standard');
