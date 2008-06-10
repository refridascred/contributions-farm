-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    owner TEXT NOT NULL,
    label TEXT,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_commits_records_level ON commits_records (level);

INSERT INTO commits_records (ratio, owner, label, level) VALUES (83.79, 'strict', 'standard', 91);
INSERT INTO commits_records (ratio, owner, label, level) VALUES (27.21, 'blue', 'edge', 5);
