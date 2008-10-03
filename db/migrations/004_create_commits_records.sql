-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    label TEXT,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_commits_records_level ON commits_records (level);

INSERT INTO commits_records (score, label, level) VALUES (82.06, 'blue', 5);
INSERT INTO commits_records (score, label, level) VALUES (68.84, 'open', 31);
INSERT INTO commits_records (score, label, level) VALUES (70.33, 'open', 32);
