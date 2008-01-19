-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    created_at TIMESTAMP,
    count INTEGER NOT NULL DEFAULT 0,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_created_at ON stream_events (created_at);

INSERT INTO stream_events (active, count, weight) VALUES (36, 79, 36.33);
INSERT INTO stream_events (active, count, weight) VALUES (40, 80, 15.5);
INSERT INTO stream_events (active, count, weight) VALUES (3, 34, 91.36);
