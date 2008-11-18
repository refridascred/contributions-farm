-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    created_at TIMESTAMP,
    level INTEGER,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stream_events_ratio ON stream_events (ratio);

INSERT INTO stream_events (ratio, level, rank) VALUES (4.94, 75, 79);
INSERT INTO stream_events (ratio, level, rank) VALUES (6.31, 53, 6);
INSERT INTO stream_events (ratio, level, rank) VALUES (51.83, 10, 76);
