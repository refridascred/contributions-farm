-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    region TEXT,
    level INTEGER,
    count INTEGER NOT NULL DEFAULT 0,
    label TEXT,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_stream_events_label ON stream_events (label);

INSERT INTO stream_events (region, level, count, label, active) VALUES ('cached', 34, 4, 'open', 72);
INSERT INTO stream_events (region, level, count, label, active) VALUES ('green', 10, 50, 'primary', 28);
INSERT INTO stream_events (region, level, count, label, active) VALUES ('cached', 13, 97, 'blue', 37);
