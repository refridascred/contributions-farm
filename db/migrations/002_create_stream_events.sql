-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    rank INTEGER,
    label TEXT,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_rank ON stream_events (rank);

INSERT INTO stream_events (level, rank, label, owner) VALUES (47, 71, 'open', 'stable');
INSERT INTO stream_events (level, rank, label, owner) VALUES (18, 71, 'green', 'stable');
INSERT INTO stream_events (level, rank, label, owner) VALUES (12, 17, 'latest', 'open');
