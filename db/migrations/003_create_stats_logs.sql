-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    created_at TIMESTAMP,
    owner TEXT NOT NULL,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_owner ON stats_logs (owner);

INSERT INTO stats_logs (count, owner, weight) VALUES (34, 'blue', 85.44);
INSERT INTO stats_logs (count, owner, weight) VALUES (81, 'legacy', 42.95);
INSERT INTO stats_logs (count, owner, weight) VALUES (63, 'blue', 81.52);
