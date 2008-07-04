-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    weight REAL,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_commits_records_ratio ON commits_records (ratio);

INSERT INTO commits_records (ratio, weight, level) VALUES (57.72, 76.92, 65);
INSERT INTO commits_records (ratio, weight, level) VALUES (81.0, 39.69, 32);
