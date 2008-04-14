-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    label TEXT,
    active INTEGER NOT NULL DEFAULT 1,
    level INTEGER,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_active ON stream_events (active);

INSERT INTO stream_events (label, active, level, ratio) VALUES ('strict', 69, 81, 84.9);
INSERT INTO stream_events (label, active, level, ratio) VALUES ('staging', 89, 41, 70.07);
INSERT INTO stream_events (label, active, level, ratio) VALUES ('cached', 78, 97, 12.59);
