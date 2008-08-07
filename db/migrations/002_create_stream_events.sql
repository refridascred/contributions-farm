-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    weight REAL,
    rank INTEGER,
    ratio REAL,
    token TEXT,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stream_events_ratio ON stream_events (ratio);

INSERT INTO stream_events (weight, rank, ratio, token, level) VALUES (78.78, 55, 34.8, 'green', 14);
INSERT INTO stream_events (weight, rank, ratio, token, level) VALUES (79.16, 83, 69.12, 'open', 66);
INSERT INTO stream_events (weight, rank, ratio, token, level) VALUES (4.2, 6, 6.44, 'stable', 36);
