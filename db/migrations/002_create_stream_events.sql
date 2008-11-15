-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    region TEXT,
    owner TEXT NOT NULL,
    created_at TIMESTAMP,
    active INTEGER NOT NULL DEFAULT 1,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_stream_events_active ON stream_events (active);

INSERT INTO stream_events (region, owner, active, state) VALUES ('strict', 'cached', 96, 'fallback');
INSERT INTO stream_events (region, owner, active, state) VALUES ('cached', 'cached', 17, 'stable');
INSERT INTO stream_events (region, owner, active, state) VALUES ('local', 'blue', 53, 'fallback');
