-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    weight REAL,
    created_at TIMESTAMP,
    count INTEGER NOT NULL DEFAULT 0,
    level INTEGER,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_stream_events_state ON stream_events (state);

INSERT INTO stream_events (weight, count, level, state) VALUES (56.66, 54, 21, 'primary');
INSERT INTO stream_events (weight, count, level, state) VALUES (22.08, 81, 82, 'open');
INSERT INTO stream_events (weight, count, level, state) VALUES (61.2, 55, 68, 'blue');
