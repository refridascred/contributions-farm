-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    token TEXT,
    count INTEGER NOT NULL DEFAULT 0,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_active ON stream_events (active);

INSERT INTO stream_events (active, token, count, ratio) VALUES (81, 'latest', 61, 1.35);
INSERT INTO stream_events (active, token, count, ratio) VALUES (49, 'local', 90, 15.7);
INSERT INTO stream_events (active, token, count, ratio) VALUES (66, 'standard', 77, 60.77);
