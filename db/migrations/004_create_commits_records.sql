-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    ratio REAL,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_ratio ON commits_records (ratio);

INSERT INTO commits_records (level, ratio, weight) VALUES (19, 13.92, 50.49);
INSERT INTO commits_records (level, ratio, weight) VALUES (1, 96.18, 88.04);
INSERT INTO commits_records (level, ratio, weight) VALUES (2, 81.59, 24.22);
