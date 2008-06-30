-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    level INTEGER,
    owner TEXT NOT NULL,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_level ON commits_records (level);

INSERT INTO commits_records (active, level, owner, weight) VALUES (92, 11, 'standard', 24.69);
INSERT INTO commits_records (active, level, owner, weight) VALUES (23, 72, 'eu-west', 55.16);
INSERT INTO commits_records (active, level, owner, weight) VALUES (28, 35, 'open', 78.59);
