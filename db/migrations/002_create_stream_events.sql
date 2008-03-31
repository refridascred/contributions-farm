-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    owner TEXT NOT NULL,
    active INTEGER NOT NULL DEFAULT 1,
    token TEXT,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stream_events_active ON stream_events (active);

INSERT INTO stream_events (count, owner, active, token, level) VALUES (30, 'stable', 20, 'green', 49);
INSERT INTO stream_events (count, owner, active, token, level) VALUES (4, 'standard', 23, 'blue', 79);
INSERT INTO stream_events (count, owner, active, token, level) VALUES (88, 'cached', 4, 'staging', 37);
