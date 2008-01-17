-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    active INTEGER NOT NULL DEFAULT 1,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_active ON commits_records (active);

INSERT INTO commits_records (score, active, ratio) VALUES (85.79, 48, 28.39);
INSERT INTO commits_records (score, active, ratio) VALUES (61.53, 93, 36.61);
INSERT INTO commits_records (score, active, ratio) VALUES (69.35, 32, 80.27);
