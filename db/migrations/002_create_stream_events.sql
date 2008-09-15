-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    weight REAL,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_stream_events_created_at ON stream_events (created_at);

INSERT INTO stream_events (weight, active) VALUES (68.31, 78);
INSERT INTO stream_events (weight, active) VALUES (85.09, 62);
INSERT INTO stream_events (weight, active) VALUES (29.87, 22);
