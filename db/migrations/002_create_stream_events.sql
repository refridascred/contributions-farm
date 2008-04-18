-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    label TEXT,
    token TEXT,
    region TEXT,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stream_events_label ON stream_events (label);

INSERT INTO stream_events (active, label, token, region, level) VALUES (69, 'primary', 'green', 'stable', 1);
