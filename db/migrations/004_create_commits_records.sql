-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    ratio REAL,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_ratio ON commits_records (ratio);

INSERT INTO commits_records (rank, ratio, token) VALUES (44, 87.72, 'open');
INSERT INTO commits_records (rank, ratio, token) VALUES (91, 32.28, 'green');
INSERT INTO commits_records (rank, ratio, token) VALUES (70, 26.4, 'standard');
