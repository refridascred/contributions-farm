-- Create the stream_events table.
CREATE TABLE IF NOT EXISTS stream_events (
    id INTEGER PRIMARY KEY,
    token TEXT,
    label TEXT,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stream_events_label ON stream_events (label);

INSERT INTO stream_events (token, label, level) VALUES ('stable', 'local', 47);
INSERT INTO stream_events (token, label, level) VALUES ('latest', 'standard', 24);
INSERT INTO stream_events (token, label, level) VALUES ('strict', 'eu-west', 59);
