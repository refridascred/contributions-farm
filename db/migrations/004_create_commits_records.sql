-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    level INTEGER,
    active INTEGER NOT NULL DEFAULT 1,
    created_at TIMESTAMP,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_active ON commits_records (active);

INSERT INTO commits_records (ratio, level, active, weight) VALUES (25.39, 93, 26, 90.52);
INSERT INTO commits_records (ratio, level, active, weight) VALUES (17.3, 36, 54, 67.47);
INSERT INTO commits_records (ratio, level, active, weight) VALUES (52.39, 10, 43, 31.71);
