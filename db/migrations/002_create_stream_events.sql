-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    level INTEGER,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_label ON stream_events (label);

INSERT INTO stream_events (count, level, label) VALUES (38, 62, 'green');
INSERT INTO stream_events (count, level, label) VALUES (26, 83, 'edge');
INSERT INTO stream_events (count, level, label) VALUES (38, 36, 'green');
