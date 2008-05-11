-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    rank INTEGER,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stream_events_level ON stream_events (level);

INSERT INTO stream_events (score, rank, level) VALUES (1.24, 13, 12);
INSERT INTO stream_events (score, rank, level) VALUES (9.51, 82, 27);
INSERT INTO stream_events (score, rank, level) VALUES (62.37, 77, 3);
