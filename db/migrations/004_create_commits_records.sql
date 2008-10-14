-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    weight REAL,
    active INTEGER NOT NULL DEFAULT 1,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_commits_records_active ON commits_records (active);

INSERT INTO commits_records (ratio, weight, active, level) VALUES (98.52, 48.58, 62, 85);
INSERT INTO commits_records (ratio, weight, active, level) VALUES (40.23, 5.4, 64, 26);
INSERT INTO commits_records (ratio, weight, active, level) VALUES (29.89, 1.28, 83, 75);
