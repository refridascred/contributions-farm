-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    weight REAL,
    token TEXT,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stream_events_level ON stream_events (level);

INSERT INTO stream_events (weight, token, level) VALUES (93.07, 'stable', 37);
INSERT INTO stream_events (weight, token, level) VALUES (8.44, 'green', 45);
