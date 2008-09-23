-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    token TEXT,
    active INTEGER NOT NULL DEFAULT 1,
    level INTEGER,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_label ON stream_events (label);

INSERT INTO stream_events (token, active, level, label) VALUES ('cached', 98, 61, 'legacy');
INSERT INTO stream_events (token, active, level, label) VALUES ('green', 97, 78, 'primary');
