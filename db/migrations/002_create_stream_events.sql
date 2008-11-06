-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    region TEXT,
    active INTEGER NOT NULL DEFAULT 1,
    score REAL NOT NULL DEFAULT 0,
    level INTEGER,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stream_events_region ON stream_events (region);

INSERT INTO stream_events (region, active, score, level, rank) VALUES ('strict', 20, 25.92, 35, 70);
INSERT INTO stream_events (region, active, score, level, rank) VALUES ('eu-west', 51, 21.69, 5, 18);
