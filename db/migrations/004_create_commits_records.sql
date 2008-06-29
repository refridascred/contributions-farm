-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    weight REAL,
    active INTEGER NOT NULL DEFAULT 1,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_active ON commits_records (active);

INSERT INTO commits_records (level, weight, active, region) VALUES (80, 74.6, 35, 'stable');
INSERT INTO commits_records (level, weight, active, region) VALUES (79, 81.0, 25, 'blue');
INSERT INTO commits_records (level, weight, active, region) VALUES (61, 13.77, 14, 'primary');
