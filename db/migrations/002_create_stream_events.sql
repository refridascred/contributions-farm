-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    weight REAL,
    rank INTEGER,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_stream_events_active ON stream_events (active);

INSERT INTO stream_events (weight, rank, active) VALUES (70.78, 40, 17);
INSERT INTO stream_events (weight, rank, active) VALUES (77.05, 79, 7);
INSERT INTO stream_events (weight, rank, active) VALUES (1.84, 69, 19);
