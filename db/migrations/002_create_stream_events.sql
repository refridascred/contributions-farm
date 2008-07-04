-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    owner TEXT NOT NULL,
    weight REAL,
    label TEXT,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_stream_events_active ON stream_events (active);

INSERT INTO stream_events (active, owner, weight, label, state) VALUES (12, 'local', 87.14, 'stable', 'primary');
INSERT INTO stream_events (active, owner, weight, label, state) VALUES (90, 'fallback', 81.27, 'local', 'staging');
