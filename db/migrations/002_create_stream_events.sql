-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    level INTEGER,
    active INTEGER NOT NULL DEFAULT 1,
    ratio REAL,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_rank ON stream_events (rank);

INSERT INTO stream_events (rank, level, active, ratio, label) VALUES (68, 6, 87, 92.01, 'stable');
INSERT INTO stream_events (rank, level, active, ratio, label) VALUES (30, 90, 81, 75.18, 'fallback');
INSERT INTO stream_events (rank, level, active, ratio, label) VALUES (61, 46, 90, 35.38, 'latest');
