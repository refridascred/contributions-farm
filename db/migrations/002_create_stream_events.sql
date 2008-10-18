-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    label TEXT,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_level ON stream_events (level);

INSERT INTO stream_events (level, label, owner) VALUES (92, 'staging', 'staging');
INSERT INTO stream_events (level, label, owner) VALUES (65, 'cached', 'fallback');
INSERT INTO stream_events (level, label, owner) VALUES (50, 'edge', 'edge');
