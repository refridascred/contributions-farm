-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    rank INTEGER,
    level INTEGER,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_ratio ON stream_events (ratio);

INSERT INTO stream_events (ratio, rank, level, weight) VALUES (21.65, 47, 78, 47.03);
INSERT INTO stream_events (ratio, rank, level, weight) VALUES (3.1, 82, 1, 75.43);
