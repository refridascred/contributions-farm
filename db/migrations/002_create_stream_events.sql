-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    active INTEGER NOT NULL DEFAULT 1,
    level INTEGER,
    ratio REAL,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_level ON stream_events (level);

INSERT INTO stream_events (rank, active, level, ratio, label) VALUES (89, 82, 43, 74.23, 'standard');
INSERT INTO stream_events (rank, active, level, ratio, label) VALUES (41, 82, 90, 54.1, 'standard');
