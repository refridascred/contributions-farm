-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    token TEXT,
    level INTEGER,
    rank INTEGER,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_weight ON stream_events (weight);

INSERT INTO stream_events (token, level, rank, weight) VALUES ('cached', 98, 96, 6.97);
INSERT INTO stream_events (token, level, rank, weight) VALUES ('fallback', 28, 14, 18.09);
INSERT INTO stream_events (token, level, rank, weight) VALUES ('edge', 59, 18, 87.05);
