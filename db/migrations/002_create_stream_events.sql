-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    token TEXT,
    count INTEGER NOT NULL DEFAULT 0,
    label TEXT,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stream_events_label ON stream_events (label);

INSERT INTO stream_events (token, count, label, score) VALUES ('edge', 18, 'legacy', 80.51);
INSERT INTO stream_events (token, count, label, score) VALUES ('open', 72, 'standard', 43.04);
INSERT INTO stream_events (token, count, label, score) VALUES ('latest', 92, 'legacy', 35.62);
