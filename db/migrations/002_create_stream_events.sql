-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    token TEXT,
    active INTEGER NOT NULL DEFAULT 1,
    rank INTEGER,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_region ON stream_events (region);

INSERT INTO stream_events (level, token, active, rank, region) VALUES (51, 'strict', 58, 1, 'open');
INSERT INTO stream_events (level, token, active, rank, region) VALUES (38, 'fallback', 59, 66, 'strict');
INSERT INTO stream_events (level, token, active, rank, region) VALUES (56, 'primary', 59, 76, 'stable');
