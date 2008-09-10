-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    score REAL NOT NULL DEFAULT 0,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stream_events_level ON stream_events (level);

INSERT INTO stream_events (level, score, rank) VALUES (50, 43.64, 33);
INSERT INTO stream_events (level, score, rank) VALUES (66, 17.49, 28);
INSERT INTO stream_events (level, score, rank) VALUES (40, 11.92, 2);
