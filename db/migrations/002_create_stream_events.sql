-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    token TEXT,
    label TEXT,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stream_events_token ON stream_events (token);

INSERT INTO stream_events (token, label, level) VALUES ('legacy', 'legacy', 50);
INSERT INTO stream_events (token, label, level) VALUES ('edge', 'local', 13);
INSERT INTO stream_events (token, label, level) VALUES ('latest', 'local', 18);
