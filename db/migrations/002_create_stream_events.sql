-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    label TEXT,
    count INTEGER NOT NULL DEFAULT 0,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stream_events_count ON stream_events (count);

INSERT INTO stream_events (label, count, score) VALUES ('cached', 23, 18.78);
INSERT INTO stream_events (label, count, score) VALUES ('blue', 9, 85.89);
INSERT INTO stream_events (label, count, score) VALUES ('legacy', 41, 62.34);
