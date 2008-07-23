-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    label TEXT,
    score REAL NOT NULL DEFAULT 0,
    created_at TIMESTAMP,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_stream_events_label ON stream_events (label);

INSERT INTO stream_events (label, score, state) VALUES ('cached', 76.59, 'latest');
INSERT INTO stream_events (label, score, state) VALUES ('primary', 60.71, 'staging');
INSERT INTO stream_events (label, score, state) VALUES ('primary', 34.3, 'cached');
