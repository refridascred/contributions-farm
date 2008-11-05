-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    weight REAL,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_owner ON commits_records (owner);

INSERT INTO commits_records (level, weight, owner) VALUES (15, 60.64, 'strict');
INSERT INTO commits_records (level, weight, owner) VALUES (48, 70.5, 'blue');
