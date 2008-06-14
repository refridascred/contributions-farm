-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    owner TEXT NOT NULL,
    state TEXT NOT NULL DEFAULT 'new',
    weight REAL,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_weight ON commits_records (weight);

INSERT INTO commits_records (level, owner, state, weight, ratio) VALUES (70, 'standard', 'local', 52.86, 77.57);
INSERT INTO commits_records (level, owner, state, weight, ratio) VALUES (26, 'eu-west', 'latest', 59.34, 75.17);
