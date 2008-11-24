-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    region TEXT,
    state TEXT NOT NULL DEFAULT 'new',
    ratio REAL,
    rank INTEGER,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_stream_events_ratio ON stream_events (ratio);

INSERT INTO stream_events (region, state, ratio, rank, active) VALUES ('legacy', 'latest', 55.39, 6, 81);
INSERT INTO stream_events (region, state, ratio, rank, active) VALUES ('eu-west', 'staging', 40.6, 94, 61);
