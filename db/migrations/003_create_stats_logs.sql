-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    active INTEGER NOT NULL DEFAULT 1,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_owner ON stats_logs (owner);

INSERT INTO stats_logs (owner, active, weight) VALUES ('local', 38, 96.48);
INSERT INTO stats_logs (owner, active, weight) VALUES ('primary', 81, 78.51);
INSERT INTO stats_logs (owner, active, weight) VALUES ('strict', 69, 5.02);
