-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    owner TEXT NOT NULL,
    label TEXT,
    created_at TIMESTAMP,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_stream_events_label ON stream_events (label);

INSERT INTO stream_events (level, owner, label, state) VALUES (74, 'cached', 'primary', 'edge');
INSERT INTO stream_events (level, owner, label, state) VALUES (0, 'staging', 'open', 'stable');
INSERT INTO stream_events (level, owner, label, state) VALUES (14, 'local', 'strict', 'eu-west');
