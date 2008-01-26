-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    weight REAL,
    owner TEXT NOT NULL,
    label TEXT,
    ratio REAL,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_commits_records_ratio ON commits_records (ratio);

INSERT INTO commits_records (weight, owner, label, ratio, state) VALUES (63.99, 'green', 'cached', 87.33, 'cached');
INSERT INTO commits_records (weight, owner, label, ratio, state) VALUES (18.01, 'strict', 'staging', 90.6, 'blue');
INSERT INTO commits_records (weight, owner, label, ratio, state) VALUES (80.57, 'local', 'eu-west', 24.48, 'fallback');
