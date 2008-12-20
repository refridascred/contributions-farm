-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    owner TEXT NOT NULL,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_owner ON stats_logs (owner);

INSERT INTO stats_logs (count, owner, weight) VALUES (93, 'edge', 71.04);
INSERT INTO stats_logs (count, owner, weight) VALUES (93, 'strict', 18.42);
INSERT INTO stats_logs (count, owner, weight) VALUES (25, 'eu-west', 13.63);
