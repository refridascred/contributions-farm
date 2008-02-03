-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    weight REAL,
    token TEXT,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_ratio ON stream_events (ratio);

INSERT INTO stream_events (weight, token, ratio) VALUES (5.68, 'strict', 67.52);
INSERT INTO stream_events (weight, token, ratio) VALUES (26.91, 'edge', 41.43);
