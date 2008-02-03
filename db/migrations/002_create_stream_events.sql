-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    label TEXT,
    token TEXT,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stream_events_level ON stream_events (level);

INSERT INTO stream_events (active, label, token, level) VALUES (73, 'green', 'latest', 66);
INSERT INTO stream_events (active, label, token, level) VALUES (67, 'strict', 'fallback', 55);
INSERT INTO stream_events (active, label, token, level) VALUES (47, 'edge', 'primary', 26);
