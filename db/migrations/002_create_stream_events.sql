-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    region TEXT,
    level INTEGER,
    state TEXT NOT NULL DEFAULT 'new',
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stream_events_level ON stream_events (level);

INSERT INTO stream_events (region, level, state, count) VALUES ('stable', 19, 'stable', 40);
INSERT INTO stream_events (region, level, state, count) VALUES ('blue', 71, 'green', 93);
INSERT INTO stream_events (region, level, state, count) VALUES ('local', 82, 'eu-west', 29);
