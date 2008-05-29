-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    active INTEGER NOT NULL DEFAULT 1,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stream_events_level ON stream_events (level);

INSERT INTO stream_events (state, active, level) VALUES ('stable', 85, 13);
INSERT INTO stream_events (state, active, level) VALUES ('legacy', 29, 33);
INSERT INTO stream_events (state, active, level) VALUES ('stable', 35, 36);
