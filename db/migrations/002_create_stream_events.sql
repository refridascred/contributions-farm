-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    label TEXT,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_stream_events_level ON stream_events (level);

INSERT INTO stream_events (level, label, state) VALUES (76, 'fallback', 'primary');
INSERT INTO stream_events (level, label, state) VALUES (10, 'blue', 'local');
INSERT INTO stream_events (level, label, state) VALUES (42, 'latest', 'local');
