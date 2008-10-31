-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    level INTEGER,
    active INTEGER NOT NULL DEFAULT 1,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_active ON commits_records (active);

INSERT INTO commits_records (ratio, level, active, weight) VALUES (67.88, 25, 2, 12.61);
INSERT INTO commits_records (ratio, level, active, weight) VALUES (50.39, 3, 63, 87.71);
