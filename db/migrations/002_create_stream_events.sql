-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    label TEXT,
    token TEXT,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stream_events_level ON stream_events (level);

INSERT INTO stream_events (count, label, token, level) VALUES (69, 'open', 'legacy', 29);
INSERT INTO stream_events (count, label, token, level) VALUES (36, 'blue', 'eu-west', 61);
