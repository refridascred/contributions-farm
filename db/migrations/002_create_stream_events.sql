-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    label TEXT,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_stream_events_label ON stream_events (label);

INSERT INTO stream_events (level, label, state) VALUES (80, 'staging', 'staging');
INSERT INTO stream_events (level, label, state) VALUES (16, 'open', 'staging');
INSERT INTO stream_events (level, label, state) VALUES (86, 'latest', 'standard');
