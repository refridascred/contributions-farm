-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    token TEXT,
    ratio REAL,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_commits_records_ratio ON commits_records (ratio);

INSERT INTO commits_records (token, ratio, level) VALUES ('blue', 5.27, 23);
INSERT INTO commits_records (token, ratio, level) VALUES ('blue', 61.24, 88);
INSERT INTO commits_records (token, ratio, level) VALUES ('eu-west', 18.65, 1);
