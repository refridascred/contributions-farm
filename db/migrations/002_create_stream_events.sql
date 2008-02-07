-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    region TEXT,
    state TEXT NOT NULL DEFAULT 'new',
    created_at TIMESTAMP,
    level INTEGER,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_ratio ON stream_events (ratio);

INSERT INTO stream_events (region, state, level, ratio) VALUES ('eu-west', 'local', 47, 75.54);
INSERT INTO stream_events (region, state, level, ratio) VALUES ('latest', 'eu-west', 49, 83.45);
