-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    region TEXT,
    active INTEGER NOT NULL DEFAULT 1,
    level INTEGER,
    state TEXT NOT NULL DEFAULT 'new',
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_active ON commits_records (active);

INSERT INTO commits_records (region, active, level, state, weight) VALUES ('primary', 34, 22, 'staging', 98.39);
INSERT INTO commits_records (region, active, level, state, weight) VALUES ('open', 14, 50, 'primary', 59.08);
INSERT INTO commits_records (region, active, level, state, weight) VALUES ('cached', 90, 94, 'stable', 98.77);
