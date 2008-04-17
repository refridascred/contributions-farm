-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    weight REAL,
    owner TEXT NOT NULL,
    ratio REAL,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_owner ON stats_logs (owner);

INSERT INTO stats_logs (level, weight, owner, ratio, state) VALUES (89, 71.11, 'latest', 24.16, 'latest');
INSERT INTO stats_logs (level, weight, owner, ratio, state) VALUES (95, 4.21, 'green', 53.18, 'primary');
INSERT INTO stats_logs (level, weight, owner, ratio, state) VALUES (69, 83.67, 'staging', 78.02, 'eu-west');
