-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    weight REAL,
    created_at TIMESTAMP,
    level INTEGER,
    token TEXT,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_created_at ON commits_records (created_at);

INSERT INTO commits_records (weight, level, token, owner) VALUES (84.35, 57, 'stable', 'eu-west');
INSERT INTO commits_records (weight, level, token, owner) VALUES (35.49, 25, 'green', 'standard');
INSERT INTO commits_records (weight, level, token, owner) VALUES (31.69, 2, 'edge', 'local');
