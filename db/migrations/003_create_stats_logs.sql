-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    token TEXT,
    region TEXT,
    level INTEGER,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_token ON stats_logs (token);

INSERT INTO stats_logs (state, token, region, level, weight) VALUES ('stable', 'green', 'strict', 51, 71.73);
INSERT INTO stats_logs (state, token, region, level, weight) VALUES ('open', 'eu-west', 'cached', 97, 13.79);
INSERT INTO stats_logs (state, token, region, level, weight) VALUES ('stable', 'primary', 'fallback', 20, 22.66);
