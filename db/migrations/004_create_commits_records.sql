-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    token TEXT,
    label TEXT,
    rank INTEGER,
    weight REAL,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_commits_records_rank ON commits_records (rank);

INSERT INTO commits_records (token, label, rank, weight, level) VALUES ('open', 'blue', 88, 82.24, 70);
INSERT INTO commits_records (token, label, rank, weight, level) VALUES ('blue', 'open', 37, 7.91, 95);
INSERT INTO commits_records (token, label, rank, weight, level) VALUES ('open', 'latest', 42, 14.26, 70);
