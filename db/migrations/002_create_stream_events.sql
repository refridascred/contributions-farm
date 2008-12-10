-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    token TEXT,
    label TEXT,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_token ON stream_events (token);

INSERT INTO stream_events (token, label, ratio) VALUES ('strict', 'legacy', 91.4);
INSERT INTO stream_events (token, label, ratio) VALUES ('fallback', 'legacy', 97.65);
INSERT INTO stream_events (token, label, ratio) VALUES ('edge', 'local', 82.03);
