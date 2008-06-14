-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    level INTEGER,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_level ON stats_logs (level);

INSERT INTO stats_logs (state, level, token) VALUES ('open', 86, 'primary');
INSERT INTO stats_logs (state, level, token) VALUES ('eu-west', 2, 'eu-west');
