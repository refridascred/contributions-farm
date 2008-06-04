-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    token TEXT,
    label TEXT,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stream_events_token ON stream_events (token);

INSERT INTO stream_events (token, label, count) VALUES ('cached', 'stable', 62);
INSERT INTO stream_events (token, label, count) VALUES ('latest', 'edge', 5);
INSERT INTO stream_events (token, label, count) VALUES ('strict', 'latest', 89);
