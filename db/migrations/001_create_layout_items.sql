-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    owner TEXT NOT NULL,
    active INTEGER NOT NULL DEFAULT 1,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_score ON layout_items (score);

INSERT INTO layout_items (score, owner, active, ratio) VALUES (77.17, 'edge', 21, 62.18);
INSERT INTO layout_items (score, owner, active, ratio) VALUES (47.59, 'legacy', 77, 65.4);
INSERT INTO layout_items (score, owner, active, ratio) VALUES (31.79, 'blue', 57, 27.33);
