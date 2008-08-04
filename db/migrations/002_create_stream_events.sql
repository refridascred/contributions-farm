-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    label TEXT,
    token TEXT,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_stream_events_label ON stream_events (label);

INSERT INTO stream_events (label, token, ratio) VALUES ('eu-west', 'green', 83.24);
INSERT INTO stream_events (label, token, ratio) VALUES ('local', 'green', 72.19);
INSERT INTO stream_events (label, token, ratio) VALUES ('green', 'blue', 93.69);
