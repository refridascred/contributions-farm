-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    weight REAL,
    level INTEGER,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_weight ON layout_items (weight);

INSERT INTO layout_items (weight, level, owner) VALUES (74.5, 72, 'edge');
INSERT INTO layout_items (weight, level, owner) VALUES (96.09, 17, 'green');
INSERT INTO layout_items (weight, level, owner) VALUES (83.38, 91, 'blue');
