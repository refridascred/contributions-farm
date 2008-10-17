-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    state TEXT NOT NULL DEFAULT 'new',
    active INTEGER NOT NULL DEFAULT 1,
    owner TEXT NOT NULL,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_ratio ON stream_events (ratio);

INSERT INTO stream_events (ratio, state, active, owner, label) VALUES (24.27, 'edge', 96, 'open', 'green');
INSERT INTO stream_events (ratio, state, active, owner, label) VALUES (75.69, 'legacy', 71, 'strict', 'legacy');
