-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    label TEXT,
    rank INTEGER,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_level ON stats_logs (level);

INSERT INTO stats_logs (label, rank, level) VALUES ('eu-west', 87, 49);
INSERT INTO stats_logs (label, rank, level) VALUES ('green', 59, 28);
INSERT INTO stats_logs (label, rank, level) VALUES ('standard', 86, 71);
