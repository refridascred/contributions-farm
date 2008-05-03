-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    token TEXT,
    active INTEGER NOT NULL DEFAULT 1,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stream_events_active ON stream_events (active);

INSERT INTO stream_events (token, active, count) VALUES ('blue', 65, 92);
INSERT INTO stream_events (token, active, count) VALUES ('legacy', 46, 70);
INSERT INTO stream_events (token, active, count) VALUES ('green', 54, 40);
