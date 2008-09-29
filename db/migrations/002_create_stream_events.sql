-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    label TEXT,
    level INTEGER,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_stream_events_level ON stream_events (level);

INSERT INTO stream_events (count, label, level, state) VALUES (65, 'latest', 40, 'open');
INSERT INTO stream_events (count, label, level, state) VALUES (23, 'edge', 75, 'eu-west');
INSERT INTO stream_events (count, label, level, state) VALUES (79, 'open', 47, 'standard');
