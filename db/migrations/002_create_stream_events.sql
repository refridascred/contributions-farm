-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    label TEXT,
    region TEXT,
    level INTEGER,
    state TEXT NOT NULL DEFAULT 'new',
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_stream_events_label ON stream_events (label);

INSERT INTO stream_events (label, region, level, state, active) VALUES ('edge', 'strict', 92, 'open', 85);
INSERT INTO stream_events (label, region, level, state, active) VALUES ('fallback', 'stable', 40, 'cached', 62);
INSERT INTO stream_events (label, region, level, state, active) VALUES ('green', 'strict', 66, 'open', 82);
