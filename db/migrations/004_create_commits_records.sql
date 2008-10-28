-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    weight REAL,
    label TEXT,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_token ON commits_records (token);

INSERT INTO commits_records (weight, label, token) VALUES (87.18, 'stable', 'primary');
INSERT INTO commits_records (weight, label, token) VALUES (4.96, 'strict', 'latest');
