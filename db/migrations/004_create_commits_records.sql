-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    weight REAL,
    ratio REAL,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_commits_records_ratio ON commits_records (ratio);

INSERT INTO commits_records (level, weight, ratio, active) VALUES (25, 57.67, 84.44, 26);
INSERT INTO commits_records (level, weight, ratio, active) VALUES (82, 49.41, 75.39, 22);
INSERT INTO commits_records (level, weight, ratio, active) VALUES (16, 27.3, 45.63, 69);
