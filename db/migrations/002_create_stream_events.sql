-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    label TEXT,
    owner TEXT NOT NULL,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_active ON stream_events (active);

INSERT INTO stream_events (active, label, owner, ratio) VALUES (26, 'local', 'primary', 8.36);
INSERT INTO stream_events (active, label, owner, ratio) VALUES (81, 'strict', 'fallback', 36.02);
