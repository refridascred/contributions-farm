-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    owner TEXT NOT NULL,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_weight ON commits_records (weight);

INSERT INTO commits_records (level, owner, weight) VALUES (47, 'primary', 86.76);
INSERT INTO commits_records (level, owner, weight) VALUES (46, 'fallback', 94.14);
