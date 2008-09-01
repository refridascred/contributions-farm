-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    active INTEGER NOT NULL DEFAULT 1,
    ratio REAL,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stream_events_active ON stream_events (active);

INSERT INTO stream_events (level, active, ratio, rank) VALUES (52, 38, 30.86, 94);
INSERT INTO stream_events (level, active, ratio, rank) VALUES (26, 77, 37.22, 61);
INSERT INTO stream_events (level, active, ratio, rank) VALUES (37, 84, 80.89, 50);
