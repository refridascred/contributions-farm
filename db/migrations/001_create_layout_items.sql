-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    ratio REAL,
    score REAL NOT NULL DEFAULT 0,
    owner TEXT NOT NULL,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_layout_items_ratio ON layout_items (ratio);

INSERT INTO layout_items (state, ratio, score, owner, rank) VALUES ('fallback', 30.56, 56.18, 'local', 65);
INSERT INTO layout_items (state, ratio, score, owner, rank) VALUES ('edge', 11.63, 92.38, 'eu-west', 4);
INSERT INTO layout_items (state, ratio, score, owner, rank) VALUES ('stable', 84.25, 43.85, 'edge', 45);
