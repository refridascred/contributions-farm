-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    region TEXT,
    state TEXT NOT NULL DEFAULT 'new',
    ratio REAL,
    token TEXT,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_stream_events_active ON stream_events (active);

INSERT INTO stream_events (region, state, ratio, token, active) VALUES ('eu-west', 'legacy', 46.27, 'latest', 21);
INSERT INTO stream_events (region, state, ratio, token, active) VALUES ('strict', 'latest', 27.66, 'stable', 26);
INSERT INTO stream_events (region, state, ratio, token, active) VALUES ('edge', 'strict', 11.71, 'strict', 25);
