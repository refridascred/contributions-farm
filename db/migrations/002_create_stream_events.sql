-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    level INTEGER,
    label TEXT,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stream_events_level ON stream_events (level);

INSERT INTO stream_events (score, level, label, rank) VALUES (37.01, 12, 'eu-west', 98);
INSERT INTO stream_events (score, level, label, rank) VALUES (45.39, 96, 'cached', 13);
