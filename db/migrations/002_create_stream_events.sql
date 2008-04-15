-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    label TEXT,
    score REAL NOT NULL DEFAULT 0,
    region TEXT,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_stream_events_label ON stream_events (label);

INSERT INTO stream_events (label, score, region, state) VALUES ('eu-west', 7.19, 'edge', 'green');
INSERT INTO stream_events (label, score, region, state) VALUES ('legacy', 90.26, 'blue', 'standard');
