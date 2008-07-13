-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    label TEXT,
    weight REAL,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stream_events_level ON stream_events (level);

INSERT INTO stream_events (label, weight, level) VALUES ('latest', 48.1, 93);
INSERT INTO stream_events (label, weight, level) VALUES ('edge', 85.61, 64);
INSERT INTO stream_events (label, weight, level) VALUES ('legacy', 36.13, 47);
