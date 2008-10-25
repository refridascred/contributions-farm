-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    state TEXT NOT NULL DEFAULT 'new',
    label TEXT,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_level ON stream_events (level);

INSERT INTO stream_events (level, state, label, ratio) VALUES (59, 'open', 'staging', 77.83);
INSERT INTO stream_events (level, state, label, ratio) VALUES (15, 'edge', 'primary', 48.94);
