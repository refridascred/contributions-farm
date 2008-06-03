-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    label TEXT,
    level INTEGER,
    score REAL NOT NULL DEFAULT 0,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_stream_events_label ON stream_events (label);

INSERT INTO stream_events (label, level, score, state) VALUES ('primary', 80, 43.18, 'stable');
INSERT INTO stream_events (label, level, score, state) VALUES ('cached', 26, 46.75, 'standard');
INSERT INTO stream_events (label, level, score, state) VALUES ('edge', 86, 21.48, 'eu-west');
