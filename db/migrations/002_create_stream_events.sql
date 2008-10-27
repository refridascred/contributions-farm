-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    level INTEGER,
    rank INTEGER,
    region TEXT,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_label ON stream_events (label);

INSERT INTO stream_events (state, level, rank, region, label) VALUES ('open', 43, 17, 'green', 'stable');
INSERT INTO stream_events (state, level, rank, region, label) VALUES ('eu-west', 60, 79, 'strict', 'edge');
