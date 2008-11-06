-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    owner TEXT NOT NULL,
    level INTEGER,
    token TEXT,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stream_events_level ON stream_events (level);

INSERT INTO stream_events (count, owner, level, token, rank) VALUES (21, 'fallback', 61, 'standard', 80);
INSERT INTO stream_events (count, owner, level, token, rank) VALUES (19, 'stable', 62, 'local', 29);
INSERT INTO stream_events (count, owner, level, token, rank) VALUES (43, 'primary', 75, 'blue', 65);
