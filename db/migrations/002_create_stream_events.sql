-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    created_at TIMESTAMP,
    count INTEGER NOT NULL DEFAULT 0,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_count ON stream_events (count);

INSERT INTO stream_events (state, count, weight) VALUES ('standard', 70, 77.61);
INSERT INTO stream_events (state, count, weight) VALUES ('latest', 81, 33.3);
INSERT INTO stream_events (state, count, weight) VALUES ('cached', 76, 91.61);
