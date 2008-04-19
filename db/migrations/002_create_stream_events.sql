-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    created_at TIMESTAMP,
    weight REAL,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stream_events_created_at ON stream_events (created_at);

INSERT INTO stream_events (active, weight, count) VALUES (34, 8.65, 89);
INSERT INTO stream_events (active, weight, count) VALUES (16, 67.74, 79);
INSERT INTO stream_events (active, weight, count) VALUES (97, 42.47, 55);
