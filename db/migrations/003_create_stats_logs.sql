-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    region TEXT,
    state TEXT NOT NULL DEFAULT 'new',
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_state ON stats_logs (state);

INSERT INTO stats_logs (region, state, weight) VALUES ('open', 'open', 26.65);
INSERT INTO stats_logs (region, state, weight) VALUES ('primary', 'eu-west', 4.79);
INSERT INTO stats_logs (region, state, weight) VALUES ('staging', 'latest', 89.3);
