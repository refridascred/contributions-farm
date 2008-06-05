-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    rank INTEGER,
    ratio REAL,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_rank ON stream_events (rank);

INSERT INTO stream_events (active, rank, ratio, label) VALUES (61, 13, 0.68, 'strict');
INSERT INTO stream_events (active, rank, ratio, label) VALUES (6, 65, 95.94, 'cached');
INSERT INTO stream_events (active, rank, ratio, label) VALUES (37, 28, 50.73, 'strict');
