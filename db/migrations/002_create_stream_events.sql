-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    ratio REAL,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stream_events_ratio ON stream_events (ratio);

INSERT INTO stream_events (score, ratio, count) VALUES (87.03, 90.02, 10);
INSERT INTO stream_events (score, ratio, count) VALUES (13.55, 84.07, 35);
INSERT INTO stream_events (score, ratio, count) VALUES (35.23, 47.43, 66);
