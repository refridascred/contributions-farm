-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    token TEXT,
    label TEXT,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_token ON stream_events (token);

INSERT INTO stream_events (token, label, region) VALUES ('cached', 'standard', 'strict');
INSERT INTO stream_events (token, label, region) VALUES ('edge', 'standard', 'primary');
INSERT INTO stream_events (token, label, region) VALUES ('latest', 'cached', 'blue');
