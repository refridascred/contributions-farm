-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    token TEXT,
    ratio REAL,
    weight REAL,
    state TEXT NOT NULL DEFAULT 'new',
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_stream_events_ratio ON stream_events (ratio);

INSERT INTO stream_events (token, ratio, weight, state, active) VALUES ('open', 27.46, 61.7, 'latest', 84);
INSERT INTO stream_events (token, ratio, weight, state, active) VALUES ('blue', 9.74, 42.87, 'strict', 85);
