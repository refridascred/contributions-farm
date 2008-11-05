-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    owner TEXT NOT NULL,
    level INTEGER,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_ratio ON stream_events (ratio);

INSERT INTO stream_events (active, owner, level, ratio) VALUES (62, 'blue', 94, 61.55);
INSERT INTO stream_events (active, owner, level, ratio) VALUES (32, 'eu-west', 66, 51.53);
INSERT INTO stream_events (active, owner, level, ratio) VALUES (85, 'standard', 9, 44.37);
