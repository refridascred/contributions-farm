-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    label TEXT,
    count INTEGER NOT NULL DEFAULT 0,
    ratio REAL,
    rank INTEGER,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_label ON stream_events (label);

INSERT INTO stream_events (label, count, ratio, rank, weight) VALUES ('primary', 66, 65.53, 37, 29.85);
INSERT INTO stream_events (label, count, ratio, rank, weight) VALUES ('primary', 34, 92.11, 48, 53.47);
INSERT INTO stream_events (label, count, ratio, rank, weight) VALUES ('green', 74, 47.07, 5, 24.63);
