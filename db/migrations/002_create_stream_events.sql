-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    token TEXT,
    active INTEGER NOT NULL DEFAULT 1,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_token ON stream_events (token);

INSERT INTO stream_events (token, active, ratio) VALUES ('cached', 84, 11.04);
INSERT INTO stream_events (token, active, ratio) VALUES ('blue', 71, 46.1);
