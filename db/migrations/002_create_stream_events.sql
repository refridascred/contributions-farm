-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    label TEXT,
    owner TEXT NOT NULL,
    rank INTEGER,
    ratio REAL,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_rank ON stream_events (rank);

INSERT INTO stream_events (label, owner, rank, ratio, token) VALUES ('staging', 'edge', 47, 88.99, 'cached');
INSERT INTO stream_events (label, owner, rank, ratio, token) VALUES ('strict', 'strict', 4, 95.49, 'blue');
INSERT INTO stream_events (label, owner, rank, ratio, token) VALUES ('staging', 'strict', 35, 95.46, 'open');
