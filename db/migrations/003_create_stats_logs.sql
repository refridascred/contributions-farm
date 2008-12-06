-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    weight REAL,
    state TEXT NOT NULL DEFAULT 'new',
    owner TEXT NOT NULL,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_ratio ON stats_logs (ratio);

INSERT INTO stats_logs (active, weight, state, owner, ratio) VALUES (64, 91.65, 'edge', 'green', 62.22);
INSERT INTO stats_logs (active, weight, state, owner, ratio) VALUES (35, 32.63, 'eu-west', 'edge', 61.29);
