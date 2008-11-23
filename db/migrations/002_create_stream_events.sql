-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    label TEXT,
    weight REAL,
    count INTEGER NOT NULL DEFAULT 0,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stream_events_label ON stream_events (label);

INSERT INTO stream_events (state, label, weight, count, score) VALUES ('cached', 'strict', 72.44, 39, 82.84);
INSERT INTO stream_events (state, label, weight, count, score) VALUES ('strict', 'stable', 96.86, 2, 3.89);
INSERT INTO stream_events (state, label, weight, count, score) VALUES ('open', 'local', 67.36, 96, 6.86);
