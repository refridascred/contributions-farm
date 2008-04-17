-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    ratio REAL,
    count INTEGER NOT NULL DEFAULT 0,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stream_events_level ON stream_events (level);

INSERT INTO stream_events (state, ratio, count, level) VALUES ('local', 32.74, 23, 79);
INSERT INTO stream_events (state, ratio, count, level) VALUES ('green', 81.57, 27, 44);
INSERT INTO stream_events (state, ratio, count, level) VALUES ('open', 98.17, 23, 26);
