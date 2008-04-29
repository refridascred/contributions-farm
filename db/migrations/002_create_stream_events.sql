-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    region TEXT,
    label TEXT,
    score REAL NOT NULL DEFAULT 0,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_stream_events_region ON stream_events (region);

INSERT INTO stream_events (region, label, score, state) VALUES ('standard', 'local', 98.82, 'stable');
INSERT INTO stream_events (region, label, score, state) VALUES ('standard', 'standard', 69.72, 'standard');
