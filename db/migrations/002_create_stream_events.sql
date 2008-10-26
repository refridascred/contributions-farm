-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    level INTEGER,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_level ON stream_events (level);

INSERT INTO stream_events (state, level, owner) VALUES ('edge', 21, 'primary');
INSERT INTO stream_events (state, level, owner) VALUES ('blue', 84, 'eu-west');
INSERT INTO stream_events (state, level, owner) VALUES ('staging', 27, 'fallback');
