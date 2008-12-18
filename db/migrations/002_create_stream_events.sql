-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    active INTEGER NOT NULL DEFAULT 1,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_active ON stream_events (active);

INSERT INTO stream_events (rank, active, weight) VALUES (14, 73, 41.25);
INSERT INTO stream_events (rank, active, weight) VALUES (16, 12, 68.71);
INSERT INTO stream_events (rank, active, weight) VALUES (28, 30, 76.89);
