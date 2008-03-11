-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    weight REAL,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_ratio ON commits_records (ratio);

INSERT INTO commits_records (state, weight, ratio) VALUES ('eu-west', 67.17, 51.76);
INSERT INTO commits_records (state, weight, ratio) VALUES ('open', 57.58, 25.73);
INSERT INTO commits_records (state, weight, ratio) VALUES ('strict', 5.11, 66.46);
