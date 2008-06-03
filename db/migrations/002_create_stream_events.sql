-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    ratio REAL,
    active INTEGER NOT NULL DEFAULT 1,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stream_events_ratio ON stream_events (ratio);

INSERT INTO stream_events (state, ratio, active, count) VALUES ('strict', 83.28, 30, 73);
INSERT INTO stream_events (state, ratio, active, count) VALUES ('local', 11.03, 72, 86);
INSERT INTO stream_events (state, ratio, active, count) VALUES ('standard', 31.02, 3, 27);
