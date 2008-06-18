-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    state TEXT NOT NULL DEFAULT 'new',
    ratio REAL,
    level INTEGER,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_weight ON commits_records (weight);

INSERT INTO commits_records (owner, state, ratio, level, weight) VALUES ('strict', 'cached', 74.47, 32, 74.33);
INSERT INTO commits_records (owner, state, ratio, level, weight) VALUES ('blue', 'latest', 86.19, 31, 2.47);
