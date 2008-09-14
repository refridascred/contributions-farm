-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    weight REAL,
    owner TEXT NOT NULL,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_owner ON stats_logs (owner);

INSERT INTO stats_logs (weight, owner, ratio) VALUES (45.27, 'blue', 70.14);
INSERT INTO stats_logs (weight, owner, ratio) VALUES (21.39, 'eu-west', 31.15);
