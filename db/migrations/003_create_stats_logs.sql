-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    label TEXT,
    token TEXT,
    active INTEGER NOT NULL DEFAULT 1,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_created_at ON stats_logs (created_at);

INSERT INTO stats_logs (label, token, active, level) VALUES ('cached', 'green', 70, 43);
INSERT INTO stats_logs (label, token, active, level) VALUES ('cached', 'primary', 44, 9);
INSERT INTO stats_logs (label, token, active, level) VALUES ('cached', 'legacy', 14, 25);
