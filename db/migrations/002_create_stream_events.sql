-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    weight REAL,
    score REAL NOT NULL DEFAULT 0,
    level INTEGER,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_level ON stream_events (level);

INSERT INTO stream_events (weight, score, level, label) VALUES (96.39, 46.84, 89, 'staging');
INSERT INTO stream_events (weight, score, level, label) VALUES (43.7, 17.9, 87, 'stable');
