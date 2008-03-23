-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    created_at TIMESTAMP,
    weight REAL,
    owner TEXT NOT NULL,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_layout_items_weight ON layout_items (weight);

INSERT INTO layout_items (score, weight, owner, level) VALUES (67.44, 19.39, 'cached', 2);
INSERT INTO layout_items (score, weight, owner, level) VALUES (37.14, 84.14, 'stable', 5);
INSERT INTO layout_items (score, weight, owner, level) VALUES (38.09, 70.74, 'cached', 96);
