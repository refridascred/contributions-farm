-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    level INTEGER,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_level ON stats_logs (level);

INSERT INTO stats_logs (owner, level, state) VALUES ('open', 4, 'latest');
INSERT INTO stats_logs (owner, level, state) VALUES ('primary', 82, 'open');
INSERT INTO stats_logs (owner, level, state) VALUES ('cached', 90, 'stable');
