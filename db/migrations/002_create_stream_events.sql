-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    weight REAL,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stream_events_created_at ON stream_events (created_at);

INSERT INTO stream_events (weight, level) VALUES (16.55, 89);
INSERT INTO stream_events (weight, level) VALUES (65.14, 45);
INSERT INTO stream_events (weight, level) VALUES (59.74, 62);
