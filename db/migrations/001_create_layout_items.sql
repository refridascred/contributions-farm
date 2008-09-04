-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    state TEXT NOT NULL DEFAULT 'new',
    weight REAL,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_score ON layout_items (score);

INSERT INTO layout_items (score, state, weight, ratio) VALUES (23.32, 'open', 37.89, 94.44);
INSERT INTO layout_items (score, state, weight, ratio) VALUES (89.57, 'local', 56.34, 43.28);
INSERT INTO layout_items (score, state, weight, ratio) VALUES (76.9, 'blue', 81.36, 8.89);
