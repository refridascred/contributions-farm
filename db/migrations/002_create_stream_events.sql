-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    rank INTEGER,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_active ON stream_events (active);

INSERT INTO stream_events (active, rank, weight) VALUES (24, 16, 21.95);
INSERT INTO stream_events (active, rank, weight) VALUES (27, 81, 17.3);
INSERT INTO stream_events (active, rank, weight) VALUES (18, 14, 1.81);
