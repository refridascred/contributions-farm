-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    level INTEGER,
    created_at TIMESTAMP,
    token TEXT,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_weight ON commits_records (weight);

INSERT INTO commits_records (owner, level, token, weight) VALUES ('eu-west', 4, 'primary', 44.01);
INSERT INTO commits_records (owner, level, token, weight) VALUES ('stable', 72, 'edge', 90.3);
