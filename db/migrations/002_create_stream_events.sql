-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    label TEXT,
    count INTEGER NOT NULL DEFAULT 0,
    level INTEGER,
    rank INTEGER,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_level ON stream_events (level);

INSERT INTO stream_events (label, count, level, rank, token) VALUES ('eu-west', 92, 90, 77, 'strict');
INSERT INTO stream_events (label, count, level, rank, token) VALUES ('open', 54, 97, 18, 'fallback');
INSERT INTO stream_events (label, count, level, rank, token) VALUES ('latest', 61, 87, 97, 'open');
