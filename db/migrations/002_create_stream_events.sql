-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    weight REAL,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_stream_events_ratio ON stream_events (ratio);

INSERT INTO stream_events (ratio, weight, state) VALUES (26.66, 35.09, 'open');
INSERT INTO stream_events (ratio, weight, state) VALUES (15.8, 59.78, 'local');
INSERT INTO stream_events (ratio, weight, state) VALUES (32.46, 9.7, 'fallback');
