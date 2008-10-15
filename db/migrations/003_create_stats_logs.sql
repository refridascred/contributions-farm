-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    token TEXT,
    label TEXT,
    active INTEGER NOT NULL DEFAULT 1,
    created_at TIMESTAMP,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_created_at ON stats_logs (created_at);

INSERT INTO stats_logs (token, label, active, rank) VALUES ('open', 'cached', 58, 44);
INSERT INTO stats_logs (token, label, active, rank) VALUES ('standard', 'standard', 91, 39);
INSERT INTO stats_logs (token, label, active, rank) VALUES ('fallback', 'eu-west', 40, 76);
