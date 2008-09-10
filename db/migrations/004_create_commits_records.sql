-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    token TEXT,
    ratio REAL,
    weight REAL,
    created_at TIMESTAMP,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_created_at ON commits_records (created_at);

INSERT INTO commits_records (token, ratio, weight, label) VALUES ('green', 67.09, 38.23, 'edge');
INSERT INTO commits_records (token, ratio, weight, label) VALUES ('open', 21.83, 80.82, 'stable');
INSERT INTO commits_records (token, ratio, weight, label) VALUES ('legacy', 87.12, 47.22, 'standard');
