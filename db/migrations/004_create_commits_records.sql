-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    level INTEGER,
    active INTEGER NOT NULL DEFAULT 1,
    ratio REAL,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_ratio ON commits_records (ratio);

INSERT INTO commits_records (state, level, active, ratio, weight) VALUES ('fallback', 96, 59, 43.69, 51.46);
INSERT INTO commits_records (state, level, active, ratio, weight) VALUES ('edge', 97, 45, 33.47, 43.31);
INSERT INTO commits_records (state, level, active, ratio, weight) VALUES ('primary', 51, 16, 60.7, 41.03);
