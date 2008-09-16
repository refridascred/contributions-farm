-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    rank INTEGER,
    count INTEGER NOT NULL DEFAULT 0,
    active INTEGER NOT NULL DEFAULT 1,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_rank ON stream_events (rank);

INSERT INTO stream_events (level, rank, count, active, ratio) VALUES (90, 36, 38, 91, 59.56);
INSERT INTO stream_events (level, rank, count, active, ratio) VALUES (81, 22, 66, 47, 87.38);
INSERT INTO stream_events (level, rank, count, active, ratio) VALUES (96, 27, 62, 91, 20.63);
