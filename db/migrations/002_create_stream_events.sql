-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    level INTEGER,
    weight REAL,
    owner TEXT NOT NULL,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_weight ON stream_events (weight);

INSERT INTO stream_events (state, level, weight, owner, token) VALUES ('local', 83, 58.6, 'green', 'standard');
INSERT INTO stream_events (state, level, weight, owner, token) VALUES ('latest', 1, 96.29, 'cached', 'fallback');
