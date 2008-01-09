-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    token TEXT,
    weight REAL,
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_commits_records_created_at ON commits_records (created_at);

INSERT INTO commits_records (token, weight) VALUES ('edge', 23.86);
INSERT INTO commits_records (token, weight) VALUES ('stable', 86.26);
INSERT INTO commits_records (token, weight) VALUES ('legacy', 32.91);
