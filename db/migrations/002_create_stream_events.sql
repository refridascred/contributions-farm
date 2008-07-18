-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    active INTEGER NOT NULL DEFAULT 1,
    ratio REAL,
    count INTEGER NOT NULL DEFAULT 0,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_ratio ON stream_events (ratio);

INSERT INTO stream_events (score, active, ratio, count, weight) VALUES (13.99, 94, 1.09, 42, 39.9);
INSERT INTO stream_events (score, active, ratio, count, weight) VALUES (88.73, 67, 5.68, 68, 1.71);
INSERT INTO stream_events (score, active, ratio, count, weight) VALUES (21.49, 72, 27.88, 70, 59.68);
