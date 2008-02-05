-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    token TEXT,
    weight REAL,
    level INTEGER,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_weight ON commits_records (weight);

INSERT INTO commits_records (token, weight, level, owner) VALUES ('open', 5.59, 22, 'blue');
INSERT INTO commits_records (token, weight, level, owner) VALUES ('primary', 10.84, 8, 'fallback');
