-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    active INTEGER NOT NULL DEFAULT 1,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_count ON stats_logs (count);

INSERT INTO stats_logs (count, active, owner) VALUES (69, 81, 'blue');
INSERT INTO stats_logs (count, active, owner) VALUES (77, 17, 'primary');
INSERT INTO stats_logs (count, active, owner) VALUES (88, 35, 'standard');
