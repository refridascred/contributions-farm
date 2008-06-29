-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    label TEXT,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_label ON stream_events (label);

INSERT INTO stream_events (level, label, ratio) VALUES (12, 'blue', 91.49);
INSERT INTO stream_events (level, label, ratio) VALUES (8, 'open', 82.71);
