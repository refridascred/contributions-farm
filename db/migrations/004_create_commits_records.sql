-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    weight REAL,
    owner TEXT NOT NULL,
    level INTEGER,
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_commits_records_ratio ON commits_records (ratio);

INSERT INTO commits_records (ratio, weight, owner, level) VALUES (68.66, 42.35, 'fallback', 26);
INSERT INTO commits_records (ratio, weight, owner, level) VALUES (92.22, 1.76, 'eu-west', 27);
INSERT INTO commits_records (ratio, weight, owner, level) VALUES (77.78, 72.13, 'stable', 48);
