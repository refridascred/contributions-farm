-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    ratio REAL,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stream_events_active ON stream_events (active);

INSERT INTO stream_events (active, ratio, level) VALUES (83, 71.38, 38);
INSERT INTO stream_events (active, ratio, level) VALUES (60, 88.73, 89);
INSERT INTO stream_events (active, ratio, level) VALUES (28, 81.06, 27);
