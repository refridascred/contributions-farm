-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    region TEXT,
    token TEXT,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stream_events_token ON stream_events (token);

INSERT INTO stream_events (region, token, level) VALUES ('staging', 'green', 7);
INSERT INTO stream_events (region, token, level) VALUES ('standard', 'edge', 19);
INSERT INTO stream_events (region, token, level) VALUES ('cached', 'open', 39);
