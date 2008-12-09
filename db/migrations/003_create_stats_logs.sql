-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    level INTEGER,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_owner ON stats_logs (owner);

INSERT INTO stats_logs (owner, level, weight) VALUES ('primary', 56, 14.51);
INSERT INTO stats_logs (owner, level, weight) VALUES ('latest', 70, 38.76);
INSERT INTO stats_logs (owner, level, weight) VALUES ('standard', 71, 58.22);
