-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    label TEXT,
    weight REAL,
    token TEXT,
    level INTEGER,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_stream_events_level ON stream_events (level);

INSERT INTO stream_events (label, weight, token, level, state) VALUES ('cached', 22.05, 'primary', 93, 'primary');
INSERT INTO stream_events (label, weight, token, level, state) VALUES ('stable', 69.74, 'blue', 15, 'blue');
