-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    token TEXT,
    score REAL NOT NULL DEFAULT 0,
    label TEXT,
    active INTEGER NOT NULL DEFAULT 1,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_label ON stream_events (label);

INSERT INTO stream_events (token, score, label, active, ratio) VALUES ('standard', 98.79, 'fallback', 1, 64.23);
INSERT INTO stream_events (token, score, label, active, ratio) VALUES ('local', 81.53, 'cached', 52, 65.91);
