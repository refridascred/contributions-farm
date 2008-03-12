-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    label TEXT,
    count INTEGER NOT NULL DEFAULT 0,
    owner TEXT NOT NULL,
    level INTEGER,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_stream_events_label ON stream_events (label);

INSERT INTO stream_events (label, count, owner, level, active) VALUES ('eu-west', 31, 'green', 86, 61);
INSERT INTO stream_events (label, count, owner, level, active) VALUES ('fallback', 50, 'edge', 14, 82);
INSERT INTO stream_events (label, count, owner, level, active) VALUES ('strict', 65, 'open', 25, 58);
