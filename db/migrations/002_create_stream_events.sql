-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    active INTEGER NOT NULL DEFAULT 1,
    token TEXT,
    owner TEXT NOT NULL,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_ratio ON stream_events (ratio);

INSERT INTO stream_events (level, active, token, owner, ratio) VALUES (20, 5, 'edge', 'primary', 95.39);
INSERT INTO stream_events (level, active, token, owner, ratio) VALUES (7, 98, 'strict', 'latest', 87.9);
INSERT INTO stream_events (level, active, token, owner, ratio) VALUES (50, 98, 'blue', 'open', 22.31);
