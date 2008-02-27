-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    owner TEXT NOT NULL,
    rank INTEGER,
    region TEXT,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_rank ON stream_events (rank);

INSERT INTO stream_events (level, owner, rank, region, label) VALUES (22, 'green', 63, 'stable', 'blue');
INSERT INTO stream_events (level, owner, rank, region, label) VALUES (59, 'strict', 16, 'strict', 'blue');
