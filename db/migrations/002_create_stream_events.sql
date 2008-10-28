-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    region TEXT,
    label TEXT,
    state TEXT NOT NULL DEFAULT 'new',
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_ratio ON stream_events (ratio);

INSERT INTO stream_events (region, label, state, ratio) VALUES ('latest', 'stable', 'stable', 87.35);
INSERT INTO stream_events (region, label, state, ratio) VALUES ('open', 'latest', 'stable', 87.09);
