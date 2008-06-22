-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    owner TEXT NOT NULL,
    weight REAL,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_owner ON stats_logs (owner);

INSERT INTO stats_logs (count, owner, weight, state) VALUES (64, 'fallback', 10.65, 'strict');
INSERT INTO stats_logs (count, owner, weight, state) VALUES (92, 'green', 98.85, 'blue');
INSERT INTO stats_logs (count, owner, weight, state) VALUES (7, 'blue', 10.91, 'legacy');
