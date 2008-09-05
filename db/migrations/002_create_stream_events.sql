-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    active INTEGER NOT NULL DEFAULT 1,
    rank INTEGER,
    count INTEGER NOT NULL DEFAULT 0,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_count ON stream_events (count);

INSERT INTO stream_events (level, active, rank, count, ratio) VALUES (32, 3, 61, 92, 19.03);
INSERT INTO stream_events (level, active, rank, count, ratio) VALUES (4, 61, 1, 46, 31.17);
INSERT INTO stream_events (level, active, rank, count, ratio) VALUES (71, 84, 38, 16, 70.45);
