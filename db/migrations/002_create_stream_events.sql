-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    token TEXT,
    weight REAL,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stream_events_level ON stream_events (level);

INSERT INTO stream_events (rank, token, weight, level) VALUES (49, 'strict', 20.3, 25);
INSERT INTO stream_events (rank, token, weight, level) VALUES (62, 'green', 80.42, 79);
INSERT INTO stream_events (rank, token, weight, level) VALUES (90, 'stable', 86.62, 35);
