-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    label TEXT,
    weight REAL,
    ratio REAL,
    rank INTEGER,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_stream_events_rank ON stream_events (rank);

INSERT INTO stream_events (label, weight, ratio, rank, active) VALUES ('open', 5.65, 91.28, 99, 97);
INSERT INTO stream_events (label, weight, ratio, rank, active) VALUES ('standard', 38.21, 95.67, 98, 83);
INSERT INTO stream_events (label, weight, ratio, rank, active) VALUES ('fallback', 12.22, 17.76, 82, 41);
