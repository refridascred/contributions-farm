-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    active INTEGER NOT NULL DEFAULT 1,
    created_at TIMESTAMP,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stream_events_active ON stream_events (active);

INSERT INTO stream_events (count, active, score) VALUES (64, 67, 23.79);
INSERT INTO stream_events (count, active, score) VALUES (45, 84, 81.61);
INSERT INTO stream_events (count, active, score) VALUES (68, 99, 83.13);
