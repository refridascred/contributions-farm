-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    region TEXT,
    token TEXT,
    state TEXT NOT NULL DEFAULT 'new',
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_count ON stats_logs (count);

INSERT INTO stats_logs (count, region, token, state, active) VALUES (49, 'edge', 'open', 'eu-west', 46);
INSERT INTO stats_logs (count, region, token, state, active) VALUES (71, 'local', 'latest', 'stable', 44);
INSERT INTO stats_logs (count, region, token, state, active) VALUES (29, 'local', 'primary', 'stable', 97);
