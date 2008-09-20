-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    label TEXT,
    level INTEGER,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_label ON stream_events (label);

INSERT INTO stream_events (owner, label, level, token) VALUES ('strict', 'green', 27, 'edge');
INSERT INTO stream_events (owner, label, level, token) VALUES ('standard', 'fallback', 38, 'stable');
