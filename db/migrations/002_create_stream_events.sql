-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    level INTEGER,
    region TEXT,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_stream_events_state ON stream_events (state);

INSERT INTO stream_events (owner, level, region, state) VALUES ('stable', 72, 'eu-west', 'stable');
INSERT INTO stream_events (owner, level, region, state) VALUES ('legacy', 28, 'latest', 'strict');
INSERT INTO stream_events (owner, level, region, state) VALUES ('legacy', 48, 'latest', 'fallback');
