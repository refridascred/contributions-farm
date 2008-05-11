-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    token TEXT,
    label TEXT,
    level INTEGER,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_stream_events_label ON stream_events (label);

INSERT INTO stream_events (count, token, label, level, active) VALUES (67, 'blue', 'green', 92, 91);
INSERT INTO stream_events (count, token, label, level, active) VALUES (39, 'standard', 'green', 92, 74);
INSERT INTO stream_events (count, token, label, level, active) VALUES (93, 'legacy', 'edge', 47, 79);
