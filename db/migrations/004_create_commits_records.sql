-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    owner TEXT NOT NULL,
    active INTEGER NOT NULL DEFAULT 1,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_active ON commits_records (active);

INSERT INTO commits_records (level, owner, active, weight) VALUES (49, 'green', 13, 44.03);
INSERT INTO commits_records (level, owner, active, weight) VALUES (79, 'green', 67, 42.64);
INSERT INTO commits_records (level, owner, active, weight) VALUES (28, 'cached', 5, 16.56);
