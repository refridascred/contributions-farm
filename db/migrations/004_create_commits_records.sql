-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    weight REAL,
    state TEXT NOT NULL DEFAULT 'new',
    owner TEXT NOT NULL,
    count INTEGER NOT NULL DEFAULT 0,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_commits_records_count ON commits_records (count);

INSERT INTO commits_records (weight, state, owner, count, level) VALUES (17.71, 'latest', 'primary', 78, 4);
INSERT INTO commits_records (weight, state, owner, count, level) VALUES (31.07, 'eu-west', 'green', 57, 53);
INSERT INTO commits_records (weight, state, owner, count, level) VALUES (34.16, 'cached', 'green', 27, 20);
