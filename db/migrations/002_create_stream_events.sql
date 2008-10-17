-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    ratio REAL,
    label TEXT,
    state TEXT NOT NULL DEFAULT 'new',
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stream_events_count ON stream_events (count);

INSERT INTO stream_events (rank, ratio, label, state, count) VALUES (32, 67.43, 'green', 'local', 70);
INSERT INTO stream_events (rank, ratio, label, state, count) VALUES (70, 53.51, 'latest', 'blue', 91);
INSERT INTO stream_events (rank, ratio, label, state, count) VALUES (79, 58.59, 'staging', 'stable', 98);
