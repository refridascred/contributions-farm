-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    ratio REAL,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_commits_records_ratio ON commits_records (ratio);

INSERT INTO commits_records (score, ratio, level) VALUES (77.26, 81.39, 78);
INSERT INTO commits_records (score, ratio, level) VALUES (58.69, 8.96, 50);
INSERT INTO commits_records (score, ratio, level) VALUES (71.23, 13.22, 73);
