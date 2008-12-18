-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    label TEXT,
    weight REAL,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stream_events_weight ON stream_events (weight);

INSERT INTO stream_events (rank, label, weight, count) VALUES (35, 'primary', 22.34, 50);
INSERT INTO stream_events (rank, label, weight, count) VALUES (34, 'standard', 89.93, 88);
