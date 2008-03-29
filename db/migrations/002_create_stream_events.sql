-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    weight REAL,
    active INTEGER NOT NULL DEFAULT 1,
    created_at TIMESTAMP,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stream_events_active ON stream_events (active);

INSERT INTO stream_events (weight, active, count) VALUES (17.32, 27, 2);
INSERT INTO stream_events (weight, active, count) VALUES (12.33, 6, 82);
INSERT INTO stream_events (weight, active, count) VALUES (36.19, 62, 46);
