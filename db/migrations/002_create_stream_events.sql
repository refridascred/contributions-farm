-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    label TEXT,
    ratio REAL,
    active INTEGER NOT NULL DEFAULT 1,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stream_events_label ON stream_events (label);

INSERT INTO stream_events (label, ratio, active, level) VALUES ('latest', 77.54, 35, 13);
INSERT INTO stream_events (label, ratio, active, level) VALUES ('fallback', 98.0, 99, 59);
INSERT INTO stream_events (label, ratio, active, level) VALUES ('local', 4.69, 6, 53);
