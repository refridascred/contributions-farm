-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    rank INTEGER,
    active INTEGER NOT NULL DEFAULT 1,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stream_events_rank ON stream_events (rank);

INSERT INTO stream_events (ratio, rank, active, level) VALUES (75.52, 2, 36, 53);
INSERT INTO stream_events (ratio, rank, active, level) VALUES (38.0, 98, 34, 68);
INSERT INTO stream_events (ratio, rank, active, level) VALUES (35.84, 60, 67, 52);
