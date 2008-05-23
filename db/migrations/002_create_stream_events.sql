-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    owner TEXT NOT NULL,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_stream_events_active ON stream_events (active);

INSERT INTO stream_events (score, owner, active) VALUES (4.83, 'blue', 0);
INSERT INTO stream_events (score, owner, active) VALUES (91.85, 'primary', 31);
INSERT INTO stream_events (score, owner, active) VALUES (60.63, 'legacy', 56);
