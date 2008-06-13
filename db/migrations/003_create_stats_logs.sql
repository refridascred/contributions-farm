-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    owner TEXT NOT NULL,
    rank INTEGER,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_level ON stats_logs (level);

INSERT INTO stats_logs (active, owner, rank, level) VALUES (24, 'eu-west', 34, 41);
INSERT INTO stats_logs (active, owner, rank, level) VALUES (87, 'green', 57, 63);
INSERT INTO stats_logs (active, owner, rank, level) VALUES (76, 'cached', 52, 74);
