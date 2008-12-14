-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    token TEXT,
    owner TEXT NOT NULL,
    ratio REAL,
    level INTEGER,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_token ON stats_logs (token);

INSERT INTO stats_logs (token, owner, ratio, level, active) VALUES ('latest', 'eu-west', 79.57, 22, 96);
INSERT INTO stats_logs (token, owner, ratio, level, active) VALUES ('cached', 'blue', 17.06, 60, 59);
INSERT INTO stats_logs (token, owner, ratio, level, active) VALUES ('staging', 'edge', 45.43, 79, 56);
