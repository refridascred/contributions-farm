-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    region TEXT,
    level INTEGER,
    state TEXT NOT NULL DEFAULT 'new',
    ratio REAL,
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_stream_events_state ON stream_events (state);

INSERT INTO stream_events (region, level, state, ratio) VALUES ('edge', 21, 'fallback', 29.4);
INSERT INTO stream_events (region, level, state, ratio) VALUES ('standard', 37, 'standard', 6.07);
INSERT INTO stream_events (region, level, state, ratio) VALUES ('standard', 53, 'open', 14.68);
