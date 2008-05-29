-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    label TEXT,
    level INTEGER,
    rank INTEGER,
    token TEXT,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_ratio ON commits_records (ratio);

INSERT INTO commits_records (label, level, rank, token, ratio) VALUES ('standard', 96, 99, 'latest', 90.91);
INSERT INTO commits_records (label, level, rank, token, ratio) VALUES ('standard', 39, 8, 'strict', 39.05);
INSERT INTO commits_records (label, level, rank, token, ratio) VALUES ('latest', 53, 66, 'standard', 45.38);
