-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    weight REAL,
    score REAL NOT NULL DEFAULT 0,
    owner TEXT NOT NULL,
    ratio REAL,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_layout_items_weight ON layout_items (weight);

INSERT INTO layout_items (weight, score, owner, ratio, state) VALUES (79.36, 2.13, 'latest', 21.19, 'stable');
INSERT INTO layout_items (weight, score, owner, ratio, state) VALUES (84.97, 33.48, 'legacy', 64.97, 'staging');
