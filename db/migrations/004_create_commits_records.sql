-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    ratio REAL,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_level ON commits_records (level);

INSERT INTO commits_records (level, ratio, label) VALUES (2, 80.07, 'open');
INSERT INTO commits_records (level, ratio, label) VALUES (22, 2.38, 'cached');
