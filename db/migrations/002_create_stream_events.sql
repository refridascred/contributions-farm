-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    label TEXT,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stream_events_label ON stream_events (label);

INSERT INTO stream_events (count, label, score) VALUES (83, 'cached', 19.26);
INSERT INTO stream_events (count, label, score) VALUES (25, 'staging', 58.75);
INSERT INTO stream_events (count, label, score) VALUES (71, 'fallback', 56.36);
