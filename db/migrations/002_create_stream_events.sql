-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    label TEXT,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stream_events_count ON stream_events (count);

INSERT INTO stream_events (count, label, score) VALUES (7, 'standard', 88.29);
INSERT INTO stream_events (count, label, score) VALUES (66, 'local', 53.65);
INSERT INTO stream_events (count, label, score) VALUES (85, 'cached', 7.98);
