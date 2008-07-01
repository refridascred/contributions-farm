-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    count INTEGER NOT NULL DEFAULT 0,
    state TEXT NOT NULL DEFAULT 'new',
    label TEXT,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_stream_events_label ON stream_events (label);

INSERT INTO stream_events (level, count, state, label, active) VALUES (16, 23, 'blue', 'local', 72);
INSERT INTO stream_events (level, count, state, label, active) VALUES (22, 77, 'latest', 'stable', 44);
INSERT INTO stream_events (level, count, state, label, active) VALUES (45, 28, 'blue', 'edge', 97);
