-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    region TEXT,
    state TEXT NOT NULL DEFAULT 'new',
    label TEXT,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stream_events_label ON stream_events (label);

INSERT INTO stream_events (region, state, label, rank) VALUES ('green', 'open', 'standard', 94);
INSERT INTO stream_events (region, state, label, rank) VALUES ('fallback', 'green', 'edge', 1);
INSERT INTO stream_events (region, state, label, rank) VALUES ('fallback', 'legacy', 'blue', 71);
