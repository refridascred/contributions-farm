-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    score REAL NOT NULL DEFAULT 0,
    weight REAL,
    level INTEGER,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_label ON stream_events (label);

INSERT INTO stream_events (state, score, weight, level, label) VALUES ('open', 45.61, 46.3, 8, 'green');
INSERT INTO stream_events (state, score, weight, level, label) VALUES ('standard', 72.42, 34.33, 64, 'stable');
INSERT INTO stream_events (state, score, weight, level, label) VALUES ('legacy', 18.77, 47.45, 39, 'edge');
