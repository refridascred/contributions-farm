-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    token TEXT,
    weight REAL,
    active INTEGER NOT NULL DEFAULT 1,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_owner ON commits_records (owner);

INSERT INTO commits_records (token, weight, active, owner) VALUES ('primary', 54.13, 48, 'local');
INSERT INTO commits_records (token, weight, active, owner) VALUES ('strict', 3.14, 28, 'latest');
INSERT INTO commits_records (token, weight, active, owner) VALUES ('primary', 43.89, 26, 'staging');
