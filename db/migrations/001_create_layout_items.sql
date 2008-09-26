-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    weight REAL,
    ratio REAL,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_layout_items_weight ON layout_items (weight);

INSERT INTO layout_items (weight, ratio, state) VALUES (20.08, 61.41, 'stable');
INSERT INTO layout_items (weight, ratio, state) VALUES (84.13, 33.35, 'local');
