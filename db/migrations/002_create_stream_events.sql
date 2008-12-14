-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    ratio REAL,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stream_events_rank ON stream_events (rank);

INSERT INTO stream_events (rank, ratio, level) VALUES (35, 70.73, 42);
INSERT INTO stream_events (rank, ratio, level) VALUES (75, 27.95, 95);
INSERT INTO stream_events (rank, ratio, level) VALUES (48, 63.22, 42);
