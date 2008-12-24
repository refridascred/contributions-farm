-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    label TEXT,
    count INTEGER NOT NULL DEFAULT 0,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_stream_events_count ON stream_events (count);

INSERT INTO stream_events (label, count, active) VALUES ('primary', 85, 13);
INSERT INTO stream_events (label, count, active) VALUES ('cached', 90, 79);
INSERT INTO stream_events (label, count, active) VALUES ('fallback', 43, 34);
