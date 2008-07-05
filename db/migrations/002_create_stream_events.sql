-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    created_at TIMESTAMP,
    active INTEGER NOT NULL DEFAULT 1,
    weight REAL,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stream_events_active ON stream_events (active);

INSERT INTO stream_events (rank, active, weight, count) VALUES (81, 77, 30.94, 13);
INSERT INTO stream_events (rank, active, weight, count) VALUES (42, 85, 36.38, 5);
INSERT INTO stream_events (rank, active, weight, count) VALUES (74, 46, 2.05, 35);
