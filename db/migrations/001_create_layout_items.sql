-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    owner TEXT NOT NULL,
    score REAL NOT NULL DEFAULT 0,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_score ON layout_items (score);

INSERT INTO layout_items (count, owner, score, ratio) VALUES (35, 'staging', 9.19, 70.22);
INSERT INTO layout_items (count, owner, score, ratio) VALUES (80, 'edge', 8.18, 64.25);
INSERT INTO layout_items (count, owner, score, ratio) VALUES (20, 'blue', 3.57, 62.05);
