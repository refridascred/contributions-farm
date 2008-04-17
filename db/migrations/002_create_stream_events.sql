-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    count INTEGER NOT NULL DEFAULT 0,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_stream_events_active ON stream_events (active);

INSERT INTO stream_events (state, count, active) VALUES ('local', 61, 9);
INSERT INTO stream_events (state, count, active) VALUES ('latest', 19, 36);
INSERT INTO stream_events (state, count, active) VALUES ('strict', 70, 91);
