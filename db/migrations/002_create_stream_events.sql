-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    token TEXT,
    ratio REAL,
    label TEXT,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stream_events_label ON stream_events (label);

INSERT INTO stream_events (token, ratio, label, score) VALUES ('fallback', 24.56, 'stable', 72.71);
INSERT INTO stream_events (token, ratio, label, score) VALUES ('strict', 64.55, 'legacy', 37.02);
