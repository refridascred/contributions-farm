-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    token TEXT,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_token ON stream_events (token);

INSERT INTO stream_events (state, token, ratio) VALUES ('stable', 'stable', 60.37);
INSERT INTO stream_events (state, token, ratio) VALUES ('strict', 'eu-west', 36.81);
INSERT INTO stream_events (state, token, ratio) VALUES ('strict', 'edge', 96.06);
