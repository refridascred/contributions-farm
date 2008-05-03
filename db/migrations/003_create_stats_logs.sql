-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    owner TEXT NOT NULL,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_owner ON stats_logs (owner);

INSERT INTO stats_logs (ratio, owner, weight) VALUES (39.48, 'green', 55.82);
