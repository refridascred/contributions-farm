-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    token TEXT,
    level INTEGER,
    weight REAL,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_owner ON commits_records (owner);

INSERT INTO commits_records (token, level, weight, owner) VALUES ('latest', 76, 61.28, 'stable');
INSERT INTO commits_records (token, level, weight, owner) VALUES ('legacy', 78, 5.52, 'primary');
