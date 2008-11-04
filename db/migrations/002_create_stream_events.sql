-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    token TEXT,
    score REAL NOT NULL DEFAULT 0,
    label TEXT,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stream_events_active ON stream_events (active);

INSERT INTO stream_events (active, token, score, label, level) VALUES (87, 'local', 23.65, 'latest', 57);
INSERT INTO stream_events (active, token, score, label, level) VALUES (81, 'green', 44.35, 'open', 50);
