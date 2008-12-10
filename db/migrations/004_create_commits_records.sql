-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    weight REAL,
    state TEXT NOT NULL DEFAULT 'new',
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_state ON commits_records (state);

INSERT INTO commits_records (level, weight, state, ratio) VALUES (66, 44.46, 'latest', 9.94);
INSERT INTO commits_records (level, weight, state, ratio) VALUES (79, 43.27, 'cached', 13.65);
INSERT INTO commits_records (level, weight, state, ratio) VALUES (79, 62.21, 'strict', 87.1);
