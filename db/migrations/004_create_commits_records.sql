-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    weight REAL,
    rank INTEGER,
    active INTEGER NOT NULL DEFAULT 1,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_token ON commits_records (token);

INSERT INTO commits_records (count, weight, rank, active, token) VALUES (35, 58.37, 0, 80, 'cached');
INSERT INTO commits_records (count, weight, rank, active, token) VALUES (65, 37.89, 4, 88, 'standard');
