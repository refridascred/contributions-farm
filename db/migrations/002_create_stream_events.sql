-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    owner TEXT NOT NULL,
    created_at TIMESTAMP,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_stream_events_level ON stream_events (level);

INSERT INTO stream_events (level, owner, state) VALUES (73, 'legacy', 'green');
INSERT INTO stream_events (level, owner, state) VALUES (8, 'strict', 'cached');
INSERT INTO stream_events (level, owner, state) VALUES (25, 'latest', 'staging');
