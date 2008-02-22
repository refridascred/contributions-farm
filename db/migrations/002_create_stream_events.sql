-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    owner TEXT NOT NULL,
    level INTEGER,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_rank ON stream_events (rank);

INSERT INTO stream_events (rank, owner, level, label) VALUES (60, 'stable', 36, 'staging');
INSERT INTO stream_events (rank, owner, level, label) VALUES (16, 'fallback', 34, 'open');
INSERT INTO stream_events (rank, owner, level, label) VALUES (54, 'legacy', 46, 'latest');
