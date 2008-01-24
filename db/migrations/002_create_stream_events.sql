-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    score REAL NOT NULL DEFAULT 0,
    ratio REAL,
    label TEXT,
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_stream_events_label ON stream_events (label);

INSERT INTO stream_events (state, score, ratio, label) VALUES ('strict', 38.82, 23.73, 'stable');
INSERT INTO stream_events (state, score, ratio, label) VALUES ('green', 48.44, 2.29, 'primary');
