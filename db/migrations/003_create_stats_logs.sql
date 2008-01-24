-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    weight REAL,
    level INTEGER,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_owner ON stats_logs (owner);

INSERT INTO stats_logs (owner, weight, level, token) VALUES ('primary', 37.36, 6, 'stable');
INSERT INTO stats_logs (owner, weight, level, token) VALUES ('open', 22.49, 43, 'stable');
