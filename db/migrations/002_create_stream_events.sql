-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    owner TEXT NOT NULL,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_stream_events_ratio ON stream_events (ratio);

INSERT INTO stream_events (ratio, owner, active) VALUES (49.71, 'stable', 83);
INSERT INTO stream_events (ratio, owner, active) VALUES (21.32, 'standard', 77);
INSERT INTO stream_events (ratio, owner, active) VALUES (74.24, 'strict', 46);
