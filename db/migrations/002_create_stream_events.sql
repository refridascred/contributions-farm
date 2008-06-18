-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    weight REAL,
    level INTEGER,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stream_events_level ON stream_events (level);

INSERT INTO stream_events (weight, level, score) VALUES (70.4, 52, 3.84);
INSERT INTO stream_events (weight, level, score) VALUES (46.25, 63, 15.82);
