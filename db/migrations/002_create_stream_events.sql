-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    count INTEGER NOT NULL DEFAULT 0,
    rank INTEGER,
    token TEXT,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_rank ON stream_events (rank);

INSERT INTO stream_events (ratio, count, rank, token, label) VALUES (46.42, 56, 43, 'standard', 'latest');
INSERT INTO stream_events (ratio, count, rank, token, label) VALUES (39.92, 93, 32, 'latest', 'primary');
INSERT INTO stream_events (ratio, count, rank, token, label) VALUES (28.01, 70, 0, 'latest', 'cached');
