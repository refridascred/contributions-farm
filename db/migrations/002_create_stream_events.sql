-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    label TEXT,
    weight REAL,
    token TEXT,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stream_events_weight ON stream_events (weight);

INSERT INTO stream_events (state, label, weight, token, rank) VALUES ('legacy', 'primary', 13.03, 'stable', 19);
INSERT INTO stream_events (state, label, weight, token, rank) VALUES ('staging', 'edge', 98.65, 'local', 82);
