-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    label TEXT,
    count INTEGER NOT NULL DEFAULT 0,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_count ON stream_events (count);

INSERT INTO stream_events (label, count, weight) VALUES ('edge', 50, 9.92);
INSERT INTO stream_events (label, count, weight) VALUES ('cached', 97, 68.59);
INSERT INTO stream_events (label, count, weight) VALUES ('blue', 88, 56.74);
