-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    owner TEXT NOT NULL,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_owner ON stats_logs (owner);

INSERT INTO stats_logs (level, owner, weight) VALUES (99, 'stable', 50.39);
INSERT INTO stats_logs (level, owner, weight) VALUES (18, 'eu-west', 51.24);
