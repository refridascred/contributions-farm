-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    created_at TIMESTAMP,
    owner TEXT NOT NULL,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_stream_events_level ON stream_events (level);

INSERT INTO stream_events (level, owner, state) VALUES (16, 'staging', 'cached');
INSERT INTO stream_events (level, owner, state) VALUES (4, 'fallback', 'green');
INSERT INTO stream_events (level, owner, state) VALUES (29, 'blue', 'legacy');
