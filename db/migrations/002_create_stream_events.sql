-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    created_at TIMESTAMP,
    ratio REAL,
    label TEXT,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stream_events_label ON stream_events (label);

INSERT INTO stream_events (state, ratio, label, score) VALUES ('primary', 75.33, 'blue', 92.93);
INSERT INTO stream_events (state, ratio, label, score) VALUES ('strict', 19.01, 'cached', 54.67);
INSERT INTO stream_events (state, ratio, label, score) VALUES ('blue', 18.83, 'staging', 70.18);
