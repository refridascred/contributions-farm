-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    label TEXT,
    active INTEGER NOT NULL DEFAULT 1,
    level INTEGER,
    state TEXT NOT NULL DEFAULT 'new',
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_stream_events_state ON stream_events (state);

INSERT INTO stream_events (label, active, level, state) VALUES ('staging', 81, 9, 'blue');
INSERT INTO stream_events (label, active, level, state) VALUES ('edge', 64, 36, 'primary');
INSERT INTO stream_events (label, active, level, state) VALUES ('local', 94, 7, 'standard');
