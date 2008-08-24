-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    label TEXT,
    owner TEXT NOT NULL,
    ratio REAL,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_rank ON stream_events (rank);

INSERT INTO stream_events (rank, label, owner, ratio, weight) VALUES (24, 'stable', 'stable', 67.15, 71.49);
INSERT INTO stream_events (rank, label, owner, ratio, weight) VALUES (2, 'strict', 'staging', 55.56, 71.53);
INSERT INTO stream_events (rank, label, owner, ratio, weight) VALUES (49, 'standard', 'staging', 71.96, 82.71);
