-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    owner TEXT NOT NULL,
    weight REAL,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_layout_items_score ON layout_items (score);

INSERT INTO layout_items (score, owner, weight, active) VALUES (70.13, 'primary', 95.03, 2);
INSERT INTO layout_items (score, owner, weight, active) VALUES (62.59, 'green', 40.31, 57);
INSERT INTO layout_items (score, owner, weight, active) VALUES (47.19, 'eu-west', 68.38, 83);
