-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    label TEXT,
    level INTEGER,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_label ON stream_events (label);

INSERT INTO stream_events (label, level, owner) VALUES ('fallback', 67, 'legacy');
INSERT INTO stream_events (label, level, owner) VALUES ('edge', 57, 'primary');
INSERT INTO stream_events (label, level, owner) VALUES ('standard', 37, 'fallback');
