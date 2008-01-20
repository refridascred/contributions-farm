-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    region TEXT,
    state TEXT NOT NULL DEFAULT 'new',
    created_at TIMESTAMP,
    weight REAL,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_commits_records_weight ON commits_records (weight);

INSERT INTO commits_records (region, state, weight, level) VALUES ('eu-west', 'staging', 74.27, 66);
INSERT INTO commits_records (region, state, weight, level) VALUES ('stable', 'cached', 39.39, 17);
INSERT INTO commits_records (region, state, weight, level) VALUES ('latest', 'legacy', 58.32, 26);
