-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    state TEXT NOT NULL DEFAULT 'new',
    token TEXT,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_weight ON stats_logs (weight);

INSERT INTO stats_logs (owner, state, token, weight) VALUES ('cached', 'stable', 'open', 19.53);
INSERT INTO stats_logs (owner, state, token, weight) VALUES ('eu-west', 'blue', 'stable', 65.94);
INSERT INTO stats_logs (owner, state, token, weight) VALUES ('blue', 'blue', 'edge', 22.48);
