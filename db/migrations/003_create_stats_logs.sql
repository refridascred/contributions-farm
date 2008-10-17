-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    owner TEXT NOT NULL,
    rank INTEGER,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_count ON stats_logs (count);

INSERT INTO stats_logs (count, owner, rank, ratio) VALUES (25, 'staging', 50, 39.54);
INSERT INTO stats_logs (count, owner, rank, ratio) VALUES (1, 'cached', 87, 55.06);
INSERT INTO stats_logs (count, owner, rank, ratio) VALUES (68, 'open', 50, 65.73);
