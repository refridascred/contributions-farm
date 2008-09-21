-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    level INTEGER,
    score REAL NOT NULL DEFAULT 0,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_active ON commits_records (active);

INSERT INTO commits_records (active, level, score, owner) VALUES (93, 41, 12.62, 'edge');
INSERT INTO commits_records (active, level, score, owner) VALUES (79, 62, 14.35, 'blue');
INSERT INTO commits_records (active, level, score, owner) VALUES (89, 79, 94.56, 'local');
