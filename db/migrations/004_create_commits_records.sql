-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    label TEXT,
    weight REAL,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_owner ON commits_records (owner);

INSERT INTO commits_records (level, label, weight, owner) VALUES (99, 'edge', 34.77, 'primary');
INSERT INTO commits_records (level, label, weight, owner) VALUES (23, 'eu-west', 32.94, 'green');
