-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    label TEXT,
    token TEXT,
    level INTEGER,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_stream_events_label ON stream_events (label);

INSERT INTO stream_events (state, label, token, level, active) VALUES ('open', 'stable', 'legacy', 75, 55);
INSERT INTO stream_events (state, label, token, level, active) VALUES ('strict', 'blue', 'standard', 0, 31);
INSERT INTO stream_events (state, label, token, level, active) VALUES ('strict', 'local', 'primary', 12, 54);
