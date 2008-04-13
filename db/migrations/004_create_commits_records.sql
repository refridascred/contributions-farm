-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    weight REAL,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_commits_records_ratio ON commits_records (ratio);

INSERT INTO commits_records (ratio, weight, level) VALUES (60.9, 98.62, 42);
INSERT INTO commits_records (ratio, weight, level) VALUES (57.97, 80.93, 88);
