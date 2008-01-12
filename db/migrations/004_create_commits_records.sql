-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    ratio REAL,
    state TEXT NOT NULL DEFAULT 'new',
    weight REAL,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_commits_records_level ON commits_records (level);

INSERT INTO commits_records (owner, ratio, state, weight, level) VALUES ('local', 12.57, 'strict', 95.12, 50);
INSERT INTO commits_records (owner, ratio, state, weight, level) VALUES ('blue', 91.15, 'green', 47.48, 18);
INSERT INTO commits_records (owner, ratio, state, weight, level) VALUES ('primary', 28.59, 'cached', 19.97, 20);
