-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    token TEXT,
    level INTEGER,
    weight REAL,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_stream_events_state ON stream_events (state);

INSERT INTO stream_events (token, level, weight, state) VALUES ('open', 24, 75.21, 'fallback');
INSERT INTO stream_events (token, level, weight, state) VALUES ('blue', 84, 38.03, 'legacy');
INSERT INTO stream_events (token, level, weight, state) VALUES ('blue', 88, 27.57, 'local');
