-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    weight REAL,
    rank INTEGER,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stream_events_level ON stream_events (level);

INSERT INTO stream_events (active, weight, rank, level) VALUES (37, 55.76, 82, 98);
INSERT INTO stream_events (active, weight, rank, level) VALUES (11, 40.98, 50, 53);
