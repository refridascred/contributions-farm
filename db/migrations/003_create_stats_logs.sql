-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    level INTEGER,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_created_at ON stats_logs (created_at);

INSERT INTO stats_logs (level, owner) VALUES (92, 'strict');
INSERT INTO stats_logs (level, owner) VALUES (68, 'local');
INSERT INTO stats_logs (level, owner) VALUES (91, 'local');
