-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    owner TEXT NOT NULL,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_owner ON stats_logs (owner);

INSERT INTO stats_logs (count, owner, ratio) VALUES (3, 'eu-west', 94.1);
INSERT INTO stats_logs (count, owner, ratio) VALUES (51, 'fallback', 10.1);
INSERT INTO stats_logs (count, owner, ratio) VALUES (3, 'blue', 28.46);
