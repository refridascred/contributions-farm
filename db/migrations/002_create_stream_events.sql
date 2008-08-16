-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    active INTEGER NOT NULL DEFAULT 1,
    created_at TIMESTAMP,
    score REAL NOT NULL DEFAULT 0,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stream_events_level ON stream_events (level);

INSERT INTO stream_events (rank, active, score, level) VALUES (66, 55, 77.66, 70);
INSERT INTO stream_events (rank, active, score, level) VALUES (64, 45, 28.04, 88);
INSERT INTO stream_events (rank, active, score, level) VALUES (52, 68, 87.79, 93);
