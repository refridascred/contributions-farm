-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    active INTEGER NOT NULL DEFAULT 1,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stream_events_ratio ON stream_events (ratio);

INSERT INTO stream_events (ratio, active, count) VALUES (31.87, 25, 39);
INSERT INTO stream_events (ratio, active, count) VALUES (65.7, 82, 75);
INSERT INTO stream_events (ratio, active, count) VALUES (96.89, 65, 26);
