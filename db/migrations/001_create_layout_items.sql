-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    weight REAL,
    state TEXT NOT NULL DEFAULT 'new',
    score REAL NOT NULL DEFAULT 0,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_layout_items_score ON layout_items (score);

INSERT INTO layout_items (weight, state, score, count) VALUES (42.35, 'staging', 13.9, 25);
INSERT INTO layout_items (weight, state, score, count) VALUES (68.53, 'blue', 77.71, 68);
INSERT INTO layout_items (weight, state, score, count) VALUES (7.19, 'legacy', 89.22, 9);
