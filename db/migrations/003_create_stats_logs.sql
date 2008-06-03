-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    count INTEGER NOT NULL DEFAULT 0,
    label TEXT,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_count ON stats_logs (count);

INSERT INTO stats_logs (owner, count, label, ratio) VALUES ('green', 93, 'eu-west', 44.94);
INSERT INTO stats_logs (owner, count, label, ratio) VALUES ('legacy', 85, 'cached', 35.4);
INSERT INTO stats_logs (owner, count, label, ratio) VALUES ('stable', 55, 'staging', 27.78);
