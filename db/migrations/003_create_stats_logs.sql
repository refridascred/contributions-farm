-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    token TEXT,
    level INTEGER,
    state TEXT NOT NULL DEFAULT 'new',
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_state ON stats_logs (state);

INSERT INTO stats_logs (token, level, state, count) VALUES ('edge', 25, 'eu-west', 52);
INSERT INTO stats_logs (token, level, state, count) VALUES ('strict', 49, 'latest', 4);
INSERT INTO stats_logs (token, level, state, count) VALUES ('strict', 64, 'legacy', 39);
