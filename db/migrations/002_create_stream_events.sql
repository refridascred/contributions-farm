-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    ratio REAL,
    weight REAL,
    region TEXT,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_stream_events_state ON stream_events (state);

INSERT INTO stream_events (state, ratio, weight, region, token) VALUES ('cached', 19.52, 33.89, 'open', 'staging');
INSERT INTO stream_events (state, ratio, weight, region, token) VALUES ('eu-west', 35.84, 35.14, 'cached', 'standard');
INSERT INTO stream_events (state, ratio, weight, region, token) VALUES ('local', 9.12, 11.13, 'local', 'fallback');
