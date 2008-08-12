-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    weight REAL,
    region TEXT,
    state TEXT NOT NULL DEFAULT 'new',
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_weight ON layout_items (weight);

INSERT INTO layout_items (weight, region, state, owner) VALUES (84.18, 'strict', 'green', 'stable');
INSERT INTO layout_items (weight, region, state, owner) VALUES (45.54, 'primary', 'edge', 'cached');
INSERT INTO layout_items (weight, region, state, owner) VALUES (21.33, 'strict', 'standard', 'staging');
