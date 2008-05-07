-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    ratio REAL,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_commits_records_active ON commits_records (active);

INSERT INTO commits_records (active, ratio, score) VALUES (85, 38.91, 58.09);
INSERT INTO commits_records (active, ratio, score) VALUES (68, 45.83, 14.53);
INSERT INTO commits_records (active, ratio, score) VALUES (55, 79.1, 22.64);
