-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    region TEXT,
    state TEXT NOT NULL DEFAULT 'new',
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_stream_events_created_at ON stream_events (created_at);

INSERT INTO stream_events (ratio, region, state) VALUES (5.76, 'standard', 'primary');
INSERT INTO stream_events (ratio, region, state) VALUES (14.24, 'cached', 'green');
INSERT INTO stream_events (ratio, region, state) VALUES (13.51, 'standard', 'blue');
