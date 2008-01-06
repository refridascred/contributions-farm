-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    active INTEGER NOT NULL DEFAULT 1,
    count INTEGER NOT NULL DEFAULT 0,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stream_events_count ON stream_events (count);

INSERT INTO stream_events (rank, active, count, level) VALUES (15, 75, 8, 82);
INSERT INTO stream_events (rank, active, count, level) VALUES (5, 71, 80, 63);
INSERT INTO stream_events (rank, active, count, level) VALUES (57, 77, 10, 2);
