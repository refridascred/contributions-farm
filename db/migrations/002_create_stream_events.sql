-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    weight REAL,
    owner TEXT NOT NULL,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stream_events_level ON stream_events (level);

INSERT INTO stream_events (active, weight, owner, level) VALUES (86, 9.59, 'eu-west', 66);
INSERT INTO stream_events (active, weight, owner, level) VALUES (34, 84.73, 'cached', 99);
