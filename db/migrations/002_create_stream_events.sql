-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    ratio REAL,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stream_events_level ON stream_events (level);

INSERT INTO stream_events (state, ratio, level) VALUES ('blue', 63.28, 26);
INSERT INTO stream_events (state, ratio, level) VALUES ('standard', 40.46, 84);
