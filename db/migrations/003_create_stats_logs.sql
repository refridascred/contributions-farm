-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    token TEXT,
    owner TEXT NOT NULL,
    rank INTEGER,
    level INTEGER,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_level ON stats_logs (level);

INSERT INTO stats_logs (token, owner, rank, level, state) VALUES ('legacy', 'green', 83, 54, 'edge');
INSERT INTO stats_logs (token, owner, rank, level, state) VALUES ('green', 'cached', 27, 32, 'primary');
