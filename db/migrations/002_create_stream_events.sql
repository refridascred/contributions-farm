-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    active INTEGER NOT NULL DEFAULT 1,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stream_events_active ON stream_events (active);

INSERT INTO stream_events (state, active, level) VALUES ('open', 86, 70);
INSERT INTO stream_events (state, active, level) VALUES ('strict', 63, 22);
INSERT INTO stream_events (state, active, level) VALUES ('legacy', 27, 52);
