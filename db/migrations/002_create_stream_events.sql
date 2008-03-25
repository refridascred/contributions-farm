-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    token TEXT,
    level INTEGER,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_token ON stream_events (token);

INSERT INTO stream_events (token, level, ratio) VALUES ('standard', 62, 37.79);
INSERT INTO stream_events (token, level, ratio) VALUES ('legacy', 6, 49.83);
