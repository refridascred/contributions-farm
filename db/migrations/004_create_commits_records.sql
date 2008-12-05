-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    token TEXT,
    level INTEGER,
    state TEXT NOT NULL DEFAULT 'new',
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_weight ON commits_records (weight);

INSERT INTO commits_records (owner, token, level, state, weight) VALUES ('strict', 'local', 24, 'stable', 6.69);
INSERT INTO commits_records (owner, token, level, state, weight) VALUES ('fallback', 'open', 63, 'latest', 83.32);
INSERT INTO commits_records (owner, token, level, state, weight) VALUES ('primary', 'standard', 31, 'legacy', 53.17);
