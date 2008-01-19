-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    rank INTEGER,
    weight REAL,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stream_events_rank ON stream_events (rank);

INSERT INTO stream_events (ratio, rank, weight, level) VALUES (19.81, 58, 9.41, 33);
INSERT INTO stream_events (ratio, rank, weight, level) VALUES (32.94, 44, 6.33, 85);
