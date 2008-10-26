-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    owner TEXT NOT NULL,
    weight REAL,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_stream_events_weight ON stream_events (weight);

INSERT INTO stream_events (rank, owner, weight, active) VALUES (44, 'blue', 21.21, 34);
INSERT INTO stream_events (rank, owner, weight, active) VALUES (60, 'standard', 63.65, 72);
INSERT INTO stream_events (rank, owner, weight, active) VALUES (38, 'legacy', 55.17, 86);
