-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    token TEXT,
    label TEXT,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_label ON stats_logs (label);

INSERT INTO stats_logs (token, label, rank) VALUES ('fallback', 'primary', 84);
INSERT INTO stats_logs (token, label, rank) VALUES ('open', 'blue', 95);
INSERT INTO stats_logs (token, label, rank) VALUES ('fallback', 'staging', 77);
