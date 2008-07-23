-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    rank INTEGER,
    weight REAL,
    owner TEXT NOT NULL,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stream_events_rank ON stream_events (rank);

INSERT INTO stream_events (active, rank, weight, owner, level) VALUES (87, 81, 15.08, 'stable', 94);
INSERT INTO stream_events (active, rank, weight, owner, level) VALUES (88, 76, 66.28, 'standard', 58);
