-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    owner TEXT NOT NULL,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_weight ON layout_items (weight);

INSERT INTO layout_items (ratio, owner, weight) VALUES (60.65, 'standard', 43.58);
INSERT INTO layout_items (ratio, owner, weight) VALUES (67.5, 'eu-west', 84.82);
