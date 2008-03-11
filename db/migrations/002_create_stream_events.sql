-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    owner TEXT NOT NULL,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_stream_events_state ON stream_events (state);

INSERT INTO stream_events (level, owner, state) VALUES (10, 'open', 'cached');
INSERT INTO stream_events (level, owner, state) VALUES (18, 'fallback', 'strict');
INSERT INTO stream_events (level, owner, state) VALUES (56, 'staging', 'latest');
